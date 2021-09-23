using System;

namespace buoi2
{
    class Rectangle
    {
        private double length;
        private double width;

        public void Acceptdetail()
        {
            Console.Write("Nhap chieu dai: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Dien tich hinh chu nhat: " + GetArea());
        }
    }
    class Arrays:Rectangle
    {
        public void InMang()
        {
            Console.WriteLine("Nhap so luong xuat ra mang hinh: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for (int i=0; i<n; i++)
            {
                a[i] += i;
                Console.WriteLine("So thu " + i + ": " + a[i]);
            }
        }
        public void Strings()
        {
            string name = "Phuoc Nhat";
            Console.WriteLine("Ten: "+name);

            //Link strings
            char[] fname = { 'D', 'o', 'a', 'n' };
            string ho = new string(fname);
            Console.WriteLine("Ho: " + ho);

            string[] sarray = { "Phuoc", "Nhat" };
            string fullname = String.Join(" ", sarray);
            Console.WriteLine("Ho ten: " + fullname);

            DateTime hnay = new DateTime(2021, 9, 21, 11, 10, 2);
            string today = String.Format("Hom nay {0:t} ngay {0:D}", hnay);
            Console.WriteLine("\nTada: {0}", today);

            //Current day.
            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));

            //Compare strings
            string str1 = "haha";
            string str2 = "hihi";
            if(String.Compare(str1, str2) == 0)
            {
                Console.WriteLine("Giong nhau");
            }
            Console.WriteLine("Khac nhau");

            //Gets child string
            string substr = str1.Substring(2);
            Console.WriteLine("Chuoi con: " + substr);
        }
    }
    struct Book
    {
        private string BookName;
        private string Poets;
        private string Types;
        private int CodeBook;

        //Contructor with parameters
        public void InputInfo(string n, string p, string t, int id)
        {
            BookName = n;
            Poets = p;
            Types = t;
            CodeBook = id;
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}", BookName);
            Console.WriteLine("Poets: {0}", Poets);
            Console.WriteLine("Kind of: {0}", Types);
            Console.WriteLine("Barcode: {0}", CodeBook);

        }
    };
    class Program:Arrays
    {
        static void Main(string[] args)
        {
            Arrays a = new Arrays();
            Book b = new Book();

            int choice = 0;
            do
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1. Tinh dien tich hinh chu nhat.");
                Console.WriteLine("2. In mang.");
                Console.WriteLine("3. In chuoi.");
                Console.WriteLine("4. Bai tap struct.");
                Console.WriteLine("5. Thoat.");
                Console.Write("Lua chon: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        a.Acceptdetail();
                        break;
                    case 2:
                        a.InMang();
                        break;
                    case 3:
                        a.Strings();
                        break;
                    case 4:
                        b.InputInfo("Triet hoc", "Nguyen Van A", "Hoc thuat", 3127);
                        Console.WriteLine("Thong tin sach 1: \n");
                        b.Display();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Khong co lua chon nay!!!");
                        break;
                }
            } while (choice < 5);
        }
    }
}
