using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePaper.Domain
{
    internal class Model : IHaveId
    {
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public string Name { get; set; }

        public Model(int id, Brand brand, string name)
        {
            Id = id;
            Brand = brand;
            Name = name;
        }

        public Model(Brand brand, string name)
        {
            Brand = brand;

            int id = DataBase.GetIdToName("models", name);

            if (id == -1)
            {
                id = int.Parse(DataBase.
                    GetOnceValue($"INSERT INTO models (brand_id, name) VALUES ({brand.Id}, '{name}') RETURNING id"));
            }
            Id = id;
            Name = name;
        }
    }
}
