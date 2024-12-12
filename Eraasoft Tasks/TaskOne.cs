using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eraasoft_Tasks
{
    public class Person
    {
        // Attributes and Properties

        private string _Name;
        private byte _Age;

        public string Name { get { return _Name; } }
        public byte Age { get { return _Age; } }

        // Constructor 
        public Person(string name, byte age) 
        {
            this._Name = name;
            this._Age = age;
        }

        // Method
        public void PrintDetails()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name: {0}",_Name);
            Console.WriteLine("Age : {0}", _Age);
            Console.WriteLine("-----------------------------------");

        }
    }
}
