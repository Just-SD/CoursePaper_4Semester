using Microsoft.Extensions.Primitives;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CoursePaper.Domain
{
    internal class Car : IHaveId
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

        private int releaseYear;
        [NameColumnInTable("release_year")]
        public int ReleaseYear
        {
            get => releaseYear;
            set
            {
                if (value > DateTime.Now.Year || value < 1885)
                    throw new ArgumentException("Получено неверное значение года выпуска автомобиля.");
                releaseYear = value;
            }
        }

        private int enginePower;
        [NameColumnInTable("engine_power")]
        public int EnginePower
        {
            get => enginePower;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Получено неверное значение мощности двигателя автомобиля.");
                enginePower = value;
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

        private int price;
        [NameColumnInTable("price")]
        public int Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Получено неверное значение цены автомобиля.");
                price = value;
            }
        }

        private City cityOfSale;
        [NameColumnInTable("city_of_sale_id")]
        public City CityOfSale
        {
            get => cityOfSale;
            set
            {
                if (value == null)
                    throw new NullReferenceException("Полученный объект никуда не указывает.");
                cityOfSale = value;
            }
        }

        [NameColumnInTable("is_relevant")]
        public bool IsRelevant { get; set; }

        private static PropertyInfo[] propertiesUsedToAdd;

        static Car()
        {
            var attributeType = typeof(NameColumnInTableAttribute);

            propertiesUsedToAdd = typeof(Car).GetProperties().
                Where(x => x.GetCustomAttributes(attributeType, false).Length != 0).
                Where(x => ((NameColumnInTableAttribute)Attribute.GetCustomAttribute(x, attributeType)).UsingToAddElement)
                .ToArray();
        }

        public Car()
        {
            IsRelevant = true;
        }

        public Car(
            Brand brand,
            Model model,
            int releaseYear,
            int enginePower,
            string gearShiftBoxType,
            string condition,
            int price,
            City cityOfSale,
            bool isRelevant,
            int? id = null)
        {
            Brand = brand;
            Model = model;
            ReleaseYear = releaseYear;
            EnginePower = enginePower;
            GearShiftBoxType = gearShiftBoxType;
            Condition = condition;
            Price = price;
            CityOfSale = cityOfSale;
            IsRelevant = isRelevant;
            if (id != null)
                Id = (int)id;
        }

        public void AddCarInDataBase()
        {
            List<string> nameColumns = new List<string>();
            StringBuilder sb = new StringBuilder();

            Type type = typeof(Car);
            Type attributeType = typeof(NameColumnInTableAttribute);

            foreach (var attr in propertiesUsedToAdd.
                Select(x => (NameColumnInTableAttribute)Attribute.GetCustomAttribute(x, attributeType))
                .ToArray())
            {
                nameColumns.Add(attr.NameColumn);
            }

            sb.Append($"INSERT INTO cars ({string.Join(',', nameColumns)}) VALUES ");
            sb.Append($"({AddValueToRequest()});");

            DataBase.AddCar(sb.ToString());
        }

        private string AddValueToRequest()
        {
            List<string> values = new List<string>();
            Type typeIHaveIdInterface = typeof(IHaveId);

            foreach (var attr in propertiesUsedToAdd)
            {
                if (attr.PropertyType.GetInterfaces().Contains(typeIHaveIdInterface))
                    values.Add(((IHaveId)attr.GetValue(this)).Id.ToString());
                else if (attr.PropertyType == typeof(string))
                    values.Add($"'{attr.GetValue(this).ToString()}'");
                else
                    values.Add(attr.GetValue(this).ToString());
            }
            return string.Join(',', values);
        }
    }
}
