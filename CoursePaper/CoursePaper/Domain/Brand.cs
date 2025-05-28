using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePaper.Domain
{
    internal class Brand : IHaveId
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Brand(int id, string? name)
        {
            Id = id;
            this.Name = name;
        }

        public Brand(string name)
        {
            int id = DataBase.GetIdToName("brands", name);

            if (id == -1)
            {
                id = int.Parse(DataBase.GetOnceValue($"INSERT INTO brands (name) VALUES ('{name}') RETURNING id"));
            }
            Id = id;
            Name = name;
        }
    }
}
