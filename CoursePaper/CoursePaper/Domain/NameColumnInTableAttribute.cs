using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePaper.Domain
{
    internal class NameColumnInTableAttribute : Attribute
    {
        public string NameColumn { get; }
        public bool UsingToAddElement { get; }
        public NameColumnInTableAttribute(string name, bool usingToAddElement = true)
        {
            NameColumn = name;
            UsingToAddElement = usingToAddElement;
        }
    }
}
