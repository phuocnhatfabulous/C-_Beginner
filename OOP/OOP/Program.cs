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
        public void Input()
        {
            Console.WriteLine("Your name: ");
            Console.ReadLine();
            Console.WriteLine("Your age: ");
            Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("My name is {0}" + "; " + "My age is {1}", name, age);
        }
    }
    //Class 2
    class Teacher : Person
    {
        private double salary;
        private int subjects;

        void Result()
        {
            if (subjects >= 10  && salary < 1.4)
            {
                double a = subjects * salary * 1000;
            }
            else
            {
                Console.WriteLine("You are bad in months");
            }
        }
        void Payment()
        {

        }

    }
    //Class 3
    class Student : Person
    {
        private double point;
        private string types;

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
            Console.WriteLine("Press 1, 2, 3, 4 or 5 to choose");
            Console.WriteLine("1. Input information for teachers.");
            Console.WriteLine("2. Input information for student.");
            Console.WriteLine("3. Output information of teachers.");
            Console.WriteLine("4. Output information of student.");
            Console.WriteLine("5. Show the best point of student.");
            int choice;
            switch (choice)
            {
                case 0:
                    a.Input();
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

            Console.ReadKey();
        }
    }
}
