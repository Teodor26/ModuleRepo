using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Class1
    {
        static void Main()
        {
            List<Person> lp = new List<Person>();
            lp.AddRange(new[] {
                new Person{ Name = "Kate", Age = 13},
                new Person{ Name = "Kate", Age = 13},
                new Person{ Name = "Kate", Age = 13},
                new Person{ Name = "Kate", Age = 13},
                new Person{ Name = "Kate", Age = 13},
                new Person{ Name = "Kate", Age = 13}

            });
        }

        
    }

    class Person
    {
        public string Name { get; set; } 
        public int Age { get; set; }
    }

}
