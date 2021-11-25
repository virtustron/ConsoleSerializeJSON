using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerializeJSON
{
    class Person
    {
        public string Name { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }
        
        
        public Person()
        {
            this.Name = "";
            this.LastName = "";
            this.Age = 0;
        }
        

        public Person(string Name, string LastName, int Age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
        }




    }
}
