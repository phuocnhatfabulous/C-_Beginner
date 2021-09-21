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

            char[] fname = { 'D', 'o', 'a', 'n' };
            string ho = new string(fname);
            Console.WriteLine("Ho: " + ho);

            string[] sarray = { "Phuoc", "Nhat" };
            string fullname = String.Join(" ", sarray);
            Console.WriteLine("Ho ten: " + fullname);

            DateTime hnay = new DateTime(2021, 9, 21, 11, 10, 2);
            string today = String.Format("Hom nay {0:t} ngay {0:D}", hnay);
            Console.WriteLine("\nTada: {0}", today);

            string str1 = "haha";
            string str2 = "hihi";
            if(String.Compare(str1, str2) == 0)
            {
                Console.WriteLine("Giong nhau");
            }
            Console.WriteLine("Khac nhau");

        }
    }
    class Program:Arrays
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Strings();
        }
    }
}
