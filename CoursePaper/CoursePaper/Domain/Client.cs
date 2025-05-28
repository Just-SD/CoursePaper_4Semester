using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CoursePaper.Infrastructure;
using NpgsqlTypes;

namespace CoursePaper.Domain
{
    class Client : IHaveId
    {
        private int id;
        [NameColumnInTable("id", false)]
        public int Id
        {
            get => id;

            set
            {
                if (value < 0)
                    throw new ArgumentException("Получено отрицательное значение идентификатора");
                id = value;
            }
        }

        private City city;
        [NameColumnInTable("city_id")]
        public City City
        {
            get => city;
            set
            {
                if (value == null)
                    throw new NullReferenceException("Полученный объект никуда не указывает.");
                city = value;
            }
        }

        private Brand brand;
        [NameColumnInTable("brand_id")]
        public Brand Brand
        {
            get => brand;
            set
            {
                if (value == null)
                    throw new NullReferenceException("Полученный объект никуда не указывает.");
                brand = value;
            }
        }

        private Model model;
        [NameColumnInTable("model_id")]
        public Model Model
        {
            get => model;
            set
            {
                if (value == null)
                    throw new NullReferenceException("Полученный объект никуда не указывает.");
                model = value;
            }
        }

        private NpgsqlRange<int> releaseYearRange;
        [NameColumnInTable("release_year")]
        public NpgsqlRange<int> ReleaseYearRange
        {
            get => releaseYearRange;
            set
            {
                if (value.UpperBound > DateTime.Now.Year || value.LowerBound < 1885)
                    throw new ArgumentException("Указанные некорректные года выпуска автомобиля.");
                releaseYearRange = value;
            }
        }

        private NpgsqlRange<int> enginePowerRange;
        [NameColumnInTable("engine_power")]
        public NpgsqlRange<int> EnginePowerRange
        {
            get => enginePowerRange;
            set
            {
                if (value.LowerBound < 0)
                    throw new ArgumentException("Указана некорректная мощность двигателя автомобиля.");
                enginePowerRange = value;
            }
        }

        private string gearShiftBoxType;
        [NameColumnInTable("gear_shift_box_type")]
        public string GearShiftBoxType
        {
            get => gearShiftBoxType;
            set
            {
                if (value == null || value == string.Empty)
                    throw new ArgumentException("Полученная строка не содержит значения.");
                gearShiftBoxType = value;
            }
        }

        private string condition;
        [NameColumnInTable("condition")]
        public string Condition
        {
            get => condition;
            set
            {
                if (value == null || value == string.Empty)
                    throw new ArgumentException("Полученная строка не содержит значения.");
                condition = value;
            }
        }

        private NpgsqlRange<int> priceRange;
        [NameColumnInTable("price")]
        public NpgsqlRange<int> PriceRange
        {
            get => priceRange;
            set
            {
                if (value.LowerBound < 0)
                    throw new ArgumentException("Получено неверное значение цены автомобиля.");
                priceRange = value;
            }
        }

        [NameColumnInTable("is_relevant")]
        public bool IsRelevant { get; set; }

        private static PropertyInfo[] propertiesUsedToAdd;

        static Client()
        {
            var attributeType = typeof(NameColumnInTableAttribute);

            propertiesUsedToAdd = typeof(Client).GetProperties().
                Where(x => x.GetCustomAttributes(attributeType, false).Length != 0).
                Where(x => ((NameColumnInTableAttribute)Attribute.GetCustomAttribute(x, attributeType)).UsingToAddElement)
                .ToArray();
        }

        public Client()
        {
            IsRelevant = true;
        }

        public Client(City city,
            Brand brand,
            Model model,
            NpgsqlRange<int> releaseYearRange,
            NpgsqlRange<int> enginePowerRange,
            string gearShiftBoxType,
            string condition,
            NpgsqlRange<int> priceRange,
            bool isRelevant,
            int? id = null)
        {
            if (id != null)
                Id = (int)id;

            City = city;
            Brand = brand;
            Model = model;
            ReleaseYearRange = releaseYearRange;
            EnginePowerRange = enginePowerRange;
            GearShiftBoxType = gearShiftBoxType;
            Condition = condition;
            PriceRange = priceRange;
            IsRelevant = isRelevant;
        }

        public void AddClientInDataBase()
        {
            List<string> nameColumns = new List<string>();
            StringBuilder sb = new StringBuilder();

            Type type = typeof(Client);
            Type attributeType = typeof(NameColumnInTableAttribute);

            foreach (var attr in propertiesUsedToAdd.
                Select(x => (NameColumnInTableAttribute)Attribute.GetCustomAttribute(x, attributeType))
                .ToArray())
            {
                nameColumns.Add(attr.NameColumn);
            }

            sb.Append($"INSERT INTO clients ({string.Join(',', nameColumns)}) VALUES ");
            sb.Append($"({AddValueToRequest()});");

            DataBase.AddClient(sb.ToString());
        }

        private string AddValueToRequest()
        {
            List<string> values = new List<string>();
            Type typeIHaveIdInterface = typeof(IHaveId);

            foreach (var attr in propertiesUsedToAdd)
            {
                if (attr.PropertyType.GetInterfaces().Contains(typeIHaveIdInterface))
                    values.Add(((IHaveId)attr.GetValue(this)).Id.ToString());
                else if (attr.PropertyType == typeof(NpgsqlRange<int>))
                {
                    NpgsqlRange<int> range = (NpgsqlRange<int>)attr.GetValue(this);
                    values.Add($"int4range({range.LowerBound}, {range.UpperBound}, '[]')");
                }
                else if (attr.PropertyType == typeof(string))
                    values.Add($"'{attr.GetValue(this).ToString()}'");
                else
                    values.Add(attr.GetValue(this).ToString());
            }
            return string.Join(',', values);
        }

        public DataToSelectCars ConvertToDataToSelectCars()
        {
            var data = new DataToSelectCars();
            data.BrandId = Brand.Id;
            data.ModelsId = new List<int> { Model.Id };
            data.ReleaseYear = (ReleaseYearRange.LowerBound, ReleaseYearRange.UpperBound);
            data.EnginePower = (EnginePowerRange.LowerBound, EnginePowerRange.UpperBound);
            data.GearShiftBoxType = GearShiftBoxType;
            data.Condition = Condition;
            data.Price = (PriceRange.LowerBound, PriceRange.UpperBound);
            data.CityOfSaleId = City.Id;
            return data;
        }
    }
}
