using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePaper.Domain
{
    internal class City : IHaveId
    {
        public int Id { get; }
        public string Name { get; set; }

        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public City(string name)
        {
            int id = DataBase.GetIdToName("citys", name);

            if (id == -1)
            {
                id = int.Parse(DataBase.GetOnceValue($"INSERT INTO citys (name) VALUES ('{name}') RETURNING id"));
            }
            Id = id;
            Name = name;
        }
    }
}
