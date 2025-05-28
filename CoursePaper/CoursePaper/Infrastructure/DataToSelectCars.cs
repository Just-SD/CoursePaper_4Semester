using System.Text;

namespace CoursePaper.Infrastructure
{
    internal class DataToSelectCars
    {
        private Dictionary<string, string?> singleValues;
        private Dictionary<string, IEnumerable<int>?> multipleValues;
        private Dictionary<string, (string?, string?)?> rangesValues;

        public DataToSelectCars()
        {
            singleValues = new Dictionary<string, string>();
            multipleValues = new Dictionary<string, IEnumerable<int>?>();
            rangesValues = new Dictionary<string, (string?, string?)?>();

            singleValues["brand_id"] = null;
            singleValues["gear_shift_box_type"] = null;
            singleValues["condition"] = null;
            singleValues["city_of_sale_id"] = null;


            multipleValues["model_id"] = null;

            rangesValues["release_year"] = null;
            rangesValues["engine_power"] = null;
            rangesValues["price"] = null;
        }

        public int? BrandId
        {
            get
            {
                return int.Parse(singleValues["brand_id"]);
            }
            set
            {
                if (value == null)
                    singleValues["brand_id"] = null;
                else
                    singleValues["brand_id"] = $"{value}";
            }
        }

        public IEnumerable<int> ModelsId
        {
            set
            {
                if (value.Count() == 0)
                    multipleValues["model_id"] = null;
                else
                    multipleValues["model_id"] = value;
            }
        }

        public (int? lowerYear, int? upperYear) ReleaseYear
        {
            set
            {
                if (value.lowerYear == null)
                    value.lowerYear = 1885; // раньше автомобилей просто не было...
                if (value.upperYear == null)
                    value.upperYear = DateTime.Now.Year;

                rangesValues["release_year"] = ($"{value.lowerYear}", $"{value.upperYear}");
            }
        }

        public (int? lowerPower, int? upperPower) EnginePower
        {
            set
            {
                if (value.upperPower == null && value.lowerPower == null)
                    rangesValues["engine_power"] = null;
                else if (value.upperPower == null)
                    rangesValues["engine_power"] = ($"{value.lowerPower}", null);
                else if (value.lowerPower == null)
                    rangesValues["engine_power"] = (null, $"{value.upperPower}");
                else
                    rangesValues["engine_power"] = ($"{value.lowerPower}", $"{value.upperPower}");
            }
        }

        public string? GearShiftBoxType
        {
            set
            {
                if (value == null)
                    singleValues["gear_shift_box_type"] = null;
                else
                    singleValues["gear_shift_box_type"] = $"'{value}'";
            }
        }

        public string? Condition
        {
            set
            {
                if (value == null)
                    singleValues["condition"] = null;
                else
                    singleValues["condition"] = $"'{value}'";
            }
        }

        public (int? lowerPrice, int? upperPrice) Price
        {
            set
            {
                if (value.upperPrice == null && value.lowerPrice == null)
                    rangesValues["price"] = null;
                else if (value.upperPrice == null)
                    rangesValues["price"] = ($"{value.lowerPrice}", null);
                else if (value.lowerPrice == null)
                    rangesValues["price"] = (null, $"{value.upperPrice}");
                else
                    rangesValues["price"] = ($"{value.lowerPrice}", $"{value.upperPrice}");
            }
        }

        public int? CityOfSaleId
        {
            set
            {
                if (value == null)
                    singleValues["city_of_sale_id"] = null;
                else
                    singleValues["city_of_sale_id"] = $"{value}";
            }
        }

        public string GetFindCarsRequest()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM cars WHERE ");

            foreach (var (key, value) in singleValues)
            {
                if (value != null)
                    sb.Append($"{key} = {value} AND ");
            }

            foreach (var (key, value) in multipleValues)
            {
                if (value != null)
                {
                    sb.Append($"{key} IN (");

                    foreach (int i in value)
                    {
                        sb.Append($"{i},");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(") AND ");
                }
            }

            foreach (var (key, value) in rangesValues)
            {
                if (value != null)
                {
                    var (v1, v2) = (value.Value.Item1, value.Value.Item2);

                    if (v1 == null)
                        sb.Append($"{key} <= {v2} AND ");
                    else if (v2 == null)
                        sb.Append($"{key} >= {v1} AND ");
                    else
                        sb.Append($"{key} BETWEEN {v1} AND {v2} AND ");
                }
            }

            sb.Append("is_relevant;");
            return sb.ToString();
        }
    }
}
