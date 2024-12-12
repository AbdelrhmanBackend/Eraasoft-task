using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Eraasoft_Tasks
{
    public class Dog
    {
        // Attributes and Properties

        private string _Name;
        private string _Breed;

        public string Name 
        {
            get { return _Name; }
            set 
            {
                string oldValue = _Name;
                _Name = value;
                _PrintUpdatedValues(oldValue, _Name);
            }
        }
        
        public string Breed 
        {
            get { return _Breed; }
            set
            {
                string OldValue = _Breed;
                _Breed = value;
                _PrintUpdatedValues(OldValue, _Breed);
            }
        }


        // Constructor 
        public Dog(string name, string breed) 
        {
            this._Name = name;
            this._Breed = breed;
        }


        // Methods 

        private void _PrintUpdatedValues(string OldValue, string NewValue)
        {
            Console.WriteLine("Successful updated:");
            Console.WriteLine("    Old value: {0}, New value: {1}", OldValue, NewValue);
        }

        public void PrintDetails()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Breed: {0}", Breed);
            Console.WriteLine("-----------------------------------");
        }
    
    }
}
