using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    public sealed class Immutable//prevent inheritance or direct instantiation of derived classes
    {
         readonly string Name;//  prevents modifications to the properties after object creation.
        readonly int Age;

        public Immutable(string name, int age)//Initialize all the properties  through the constructor only
        {
           Name = name;
            Age = age;
        }
    }
}
