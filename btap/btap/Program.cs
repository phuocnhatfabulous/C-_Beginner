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
    //Ngay 14 thang 9 nam 2021
    class buoi2 : buoi1
    {
        char[] a;
        string username;
        string password;

        public void bai1()
        {
            string b;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nhap chu cai thu {0}:  ", i);
                char a = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(a);
        }

        public void bai2()
        {
            int i = 0;
            do {
                Console.WriteLine("Username: ");
                username = Console.ReadLine();

                Console.WriteLine("Password: ");
                password = Console.ReadLine();

                i++;
            }while((username == "admin" && password == "123") && (i < 3));

            if ((username == "admin" && password == "123") && (i == 3))
            {
                Console.WriteLine("Dang nhap thanh cong");
            }
            else
            {
                Console.WriteLine("Vui long nhap lai");
            }
        }
        public void bai3()
        {
            float a, b, c;
            Console.Write("Nhap vao a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao c: ");
            c = float.Parse(Console.ReadLine());
            float delta = (b * b) - (4 * a * c);
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b + (Math.Sqrt(delta))) / (2 * a)));
                Console.WriteLine("X2 = {0}", ((-b - (Math.Sqrt(delta))) / (2 * a)));

            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / (2 * a));
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        public void bai4()
        {
            int choice = 0;
            const double pi = 3.14;
            Console.WriteLine("------Menu-----");
            Console.WriteLine("1. Dien tich hinh tron");
            Console.WriteLine("2. Dien tich hinh vuong");
            Console.WriteLine("3. Dien tich hinh chu nhat");
            Console.Write("Lua chon: ");
            Console.ReadLine();

            switch (choice)
            {
                case 1:
                    double r, s;
                    Console.WriteLine("Nhap ban kinh: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dien tich hinh tron: {0}", s = r * r * pi);
                    break;
                case 2:
                    double c;
                    Console.WriteLine("Nhap gia tri canh: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dien tich hinh vuong: {0}", s = c * c);
                    break;
                case 3:
                    double cao, day;
                    Console.WriteLine("Nhap gia tri cao: ");
                    cao = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nhap gia tri day: ");
                    day = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dien tich hinh vuong: {0}", s = (cao * day)/2);
                    break;
                default:
                    Console.WriteLine("Lua chon khong ton tai");
                    break;
            }
        }
        public void bai5()
        {
            int choice = 0;
            double a, b;
            Console.WriteLine("------Menu-----");
            Console.WriteLine("1. Phep cong");
            Console.WriteLine("2. Phep tru");
            Console.WriteLine("3. Phep nhan");
            Console.WriteLine("4. Phep chia");

            Console.Write("Lua chon: ");
            choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double c;
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep cong: {0}", c = a + b);
                    break;
                case 2:
                    double d;
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep tru: {0}", d = a - b);
                    break;
                case 3:
                    double e;
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep nhan: {0}", e = a * b);
                    break;
                case 4:
                    double f;
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep nhan: {0}", f = a / b);
                    break;
                default:
                    Console.WriteLine("Lua chon khong ton tai");
                    break;
            }
        }
        public void bai6()
        {
            int a, kq;

            Console.WriteLine("Nhap mot so bat ky: ");
            a = Convert.ToInt16(Console.ReadLine());

            kq = a * 0;
            Console.WriteLine("Hien thi bang nhan:\n{0} x {1} = {2}", a, 0, kq);
            kq = a * 1;
            Console.WriteLine("{0} x {1} = {2}", a, 1, kq);
            kq = a * 2;
            Console.WriteLine("{0} x {1} = {2}", a, 2, kq);
            kq = a * 3;
            Console.WriteLine("{0} x {1} = {2}", a, 3, kq);
            kq = a * 4;
            Console.WriteLine("{0} x {1} = {2}", a, 4, kq);
            kq = a * 5;
            Console.WriteLine("{0} x {1} = {2}", a, 5, kq);
            kq = a * 6;
            Console.WriteLine("{0} x {1} = {2}", a, 6, kq);
            kq = a * 7;
            Console.WriteLine("{0} x {1} = {2}", a, 7, kq);
            kq = a * 8;
            Console.WriteLine("{0} x {1} = {2}", a, 8, kq);
            kq = a * 9;
            Console.WriteLine("{0} x {1} = {2}", a, 9, kq);
            kq = a * 10;
            Console.WriteLine("{0} x {1} = {2}", a, 10, kq);
        }
        public void bai7()
        {
            int i, n, sum = 0;
            Console.WriteLine("Hien thi va tinh tong n so le: ");

            Console.Write("Nhap so cac so: ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nHien thi cac so le: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nTong {0} so le ban dau la: {1} \n", n, sum);
        }
        public void bai8()
        {
            int i, f = 1, num;

            Console.WriteLine("Tim giai thua: ");

            Console.Write("Nhap mot so bat ky: ");
            num = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("Giai thua cua {0} la: {1}\n", num, f);
        }
    }
    //
    class Program
    {
        // Main function
        static void Main(string[] args)
        {

            buoi2 b = new buoi2();
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
