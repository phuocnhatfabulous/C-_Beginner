using System;

namespace DoanPhuocNhat
{
    class Program
    {
        public int key;
        public string answer;
        int i = 0;

        //Declare data types
        void Types()
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
        void VarCon()
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
        void ConditionStructure()
        {
            Console.WriteLine("Are you a robot? yes or no");
            answer = Convert.ToString(Console.ReadLine());

            Console.Write("Verifying that you're not a robot (1+1) = ");
            key = Convert.ToInt16(Console.ReadLine());

                if (key == 2 && answer == "no") //Operator ==, &&
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Again!!!");
                    ConditionStructure();
                }

            
        }
        //Menu
        void Menu()
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

        // Main function
        static void Main(string[] args)
        {
            Program a = new Program();
            a.ConditionStructure();
            
            Console.ReadKey();
        }
    }
}
