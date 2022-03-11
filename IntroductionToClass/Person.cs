using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToClass
{
    public class Person
    {
        // Contructor that takes no arguments:
        public Person()
        {
            Name = "unknow";
        }
        // Contructor that takes one arguments:
        public Person(string name)
        {
            Name = name;
        }
        // Auto-implement readonly property
        public string Name { get; }
        public override string ToString()
        {
            return Name;
        }
    }
}
