using System;

namespace DoanPhuocNhat
{
    //Ngay 7 thang 9 nam 2021
    class buoi1
    {
        public int key;
        public string answer;

        //Declare data types
        public void Types()
        {
            Console.WriteLine("Chuyen doi kieu du lieu trong C#");
            double b = 100.222;
            char c = 'N';

            //Implicit & explicit
            //Ep kieu ngam dinh, tuong minh
            int i = (int)b; //implicit: ngam dinh
            Console.WriteLine("Gia tri cua i: " + i);

            Console.WriteLine(c.ToString()); //explicit: tuong minh
        }

        //Declare variable and constant
        public void VarCon()
        {
            //Variable
            int a = 10;
            double b = 2.132;
            short c = 5;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            //Constant
            const double pi = 3.14;
            double r;
            Console.WriteLine("Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double s = r * r * pi;
            Console.WriteLine("Area = {0}"+"; "+ "{1}" , s, (int)s);
        }
        public void ConditionStructure()
        {
            int i = 0;
            Console.WriteLine("Are you a robot? yes or no");
            answer = Convert.ToString(Console.ReadLine());

            Console.Write("Verifying that you're not a robot (1+1) = ");
            key = Convert.ToInt16(Console.ReadLine());

            do
            {
                if (key == 2 && answer == "no") //Operator ==, &&
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Again!!!");
                    ConditionStructure();
                }
                
            } while (i < 3);

            Console.WriteLine("");



        }
        //Menu
        public void Menu()
        {
            Console.WriteLine("\n-----Menu-----");
            Console.WriteLine("1. Khai bao bien hang.");
            Console.WriteLine("2. Ep kieu du lieu.");
            Console.WriteLine("3. Thoat.");
            Console.Write("Chon: ");
            key = Convert.ToInt16(Console.ReadLine());

            switch (key)
            {
                case 1:
                    VarCon();
                    break;
                case 2:
                    Types();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Gia tri khong hop le");
                    break;
            }
        }
    }
    class Program
    {
        // Main function
        static void Main(string[] args)
        {

            buoi1 b = new buoi1();
            //b.ConditionStructure();
            //b.bai1();
            //b.bai2();
            //b.bai3();
            //b.bai4();
            //b.bai5();
            //b.bai6();
            //b.bai7();
            //b.bai8();


            Console.ReadKey();
        }
    }
}
