using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_App
{
    public class Person
    {
        public string name;
        public int age;

        public void Print()
        {
            Console.WriteLine($"Имя: {name}\nВозраст: {age}");
        }

        public Person() { name = "undefined"; age = 18; }
        public Person(string name) { this.name = name; age = 20; }
        public Person(string name, int age) { this.name = name; this.age = age; }

    }
}
