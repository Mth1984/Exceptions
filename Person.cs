using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }
    }
}
