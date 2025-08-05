using System;

namespace Module_6_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person Sam = new Person("Sam");
            Person Aleksandr = new Person("Aleksandr", 37);

            person.Print();
            Sam.Print();
            Aleksandr.Print();
        }
    }
}
