using System;

namespace OOP
{
    //Class 1
    class Person
    {
        public string name;
        public int age;
        public string gender;
        //Constructor with parameters
        public Person(string hoten1, int age1)
        {
            name = hoten1;
            age = age1;
        }
        //Constructor without parameter
        public Person()
        {
            name = "Doan Phuoc Nhat";
            age = 21;
        }
        //Info
        public void Screen()
        {
            Console.WriteLine("Ho ten = {0}, Tuoi = {1}", name, age);
            Console.WriteLine("Ho ten:" + name +"; "+ "Tuoi:" + age);
        }
    }
    //Class 2
    class Teacher : Person
    {
        public long salary;
        public string subject;

        void Payment()
        {

        }

    }
    //Class 3
    class Student : Person
    {
        public double point;
        public string types;

        void Average()
        {

        }

    }
    //Class 4
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.Screen();
            Console.ReadKey();
        }
    }
}
