using System;

namespace btap
{
    class Program
    {
        public string hoten;
        public int tuoi;
        public string gtinh;

        //Declare data types
        static void Types()
        {
            Console.WriteLine("Chuyen doi kieu du lieu trong C#");
            int a = 100;
            double b = 100.222;
            char c = 'N';

            int i = (int)b;
            Console.WriteLine("Gia tri cua i: " + i);

            Console.WriteLine(c.ToString());
        }
        //Contructor with parameters
        public Program(string hoten1, int tuoi1, string gtinh1)
        {
            hoten = hoten1;
            tuoi = tuoi1;
            gtinh = gtinh1;
        }
        //Contructor without parameters
        public Program()
        {

        }
        //Declare variable and constant
        void VarCon()
        {
            //Variable
            int a = 10;
            double b = 2.12;
            short c = 5;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            //Constant
            const double pi = 3.14;
            double r;
            Console.WriteLine("Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double s = r * r * pi;
            Console.WriteLine("Area = {0}", s);
        }

        // Main function
        static void Main(string[] args)
        {
            Program Info = new Program("Nhat", 21, "nam");
            Types(); //Static void Types
            Console.WriteLine(Info.hoten + " " + Info.tuoi + " " + Info.gtinh);

            //Khong can static
            Program a = new Program();
            a.VarCon();

            Console.ReadKey();
        }
    }
}
