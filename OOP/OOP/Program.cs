using System;

namespace OOP
{
    class Person
    {
        public string hoten;
        public int age;
        //Constructor with parameters
        public Person(string hoten1, int age1)
        {
            hoten = hoten1;
            age = age1;
        }
        //Constructor without parameter
        public Person()
        {
          
        }

        static void Main(string[] args)
        {
            Person a = new Person("Phuoc Nhat", 21);
            Console.WriteLine(a.hoten + " " + a.age);

            Console.ReadKey(); 
        }
    }
}
