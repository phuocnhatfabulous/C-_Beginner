using System;

namespace assignments
{
    class Program
    {
        //1. Nhap 3 chu cai va hien thi theo chieu nguoc lai
        void bai1()
        {
            //Y tuong: lay ra tung ki tu cuoi mang (str) roi gan vao mang rong (str1)
            string str, str1 = "";
            int i, l;
            Console.Write("Nhap 3 ki tu bat ki: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
            Console.WriteLine("Chuoi dao nguoc cac ki tu ban dau la: {0}", str1);
            Main();
        }


        /*
         * 2. Viet chuong trinh de nhan username va password duoi dang kieu du lieu string
         * tu nguoi dung. Neu nguoi dung nhap sai qua 3 lan, in thong bao loi
         */
        void bai2()
        {
            int i = 0;
            string username;
            string password;
            do
            {
                Console.Write("Ten dang nhap: ");
                username = Console.ReadLine();

                Console.Write("Mat khau: ");
                password = Console.ReadLine();

                i++;
            }
            while (((username != "admin") || (password != "123")) && i < 4);

            if (((username == "admin") && (password == "123"))
                && (i <= 4 ))
            {
                Console.WriteLine("Dang nhap thanh cong!");
            }
            else
                Console.WriteLine("Dang nhap that baiiii!");
            Main();
        }

        //3. Giai phuong trinh bac 2
        void bai3()
        {
            float a, b, c;
            Console.WriteLine("Giai phuong trinh bac 2:");
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
                Console.WriteLine("X1 = X2 = {0}", -b / (2 * a));
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            Main();
        }

        //4. Viet chuong trinh hien thi menu, tinh dien tich HCN, HTron, HTamGiac.
        void bai4()
        {
            int choice;
            const double pi = 3.14;
            Console.WriteLine("------Menu-----");
            Console.WriteLine("1. Dien tich hinh tron");
            Console.WriteLine("2. Dien tich hinh vuong");
            Console.WriteLine("3. Dien tich hinh chu nhat");
            Console.Write("Lua chon: ");
            choice = Convert.ToInt16(Console.ReadLine());

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
                    Console.WriteLine("Dien tich hinh vuong: {0}", s = (cao * day) / 2);
                    break;
                default:
                    Console.WriteLine("Lua chon khong ton tai");
                    break;
            }
            Main();
        }

        //5. Viet menu thuc hien cac phep toan co ban. (+ - * /)
        void bai5()
        {
            int choice;
            double a, b, kq;
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
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep cong: {0}", kq = a + b);
                    break;
                case 2:
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep tru: {0}", kq = a - b);
                    break;
                case 3:
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep nhan: {0}", kq = a * b);
                    break;
                case 4:
                    Console.WriteLine("Nhap 2 chu so can tinh: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ket qua phep nhan: {0}", kq = a / b);
                    break;
                default:
                    Console.WriteLine("Lua chon khong ton tai");
                    break;
            }
            Main();
        }

        //6. Viet chuong trinh nhap 1 so va in ra bang nhan cua so do
        void bai6()
        {
            int a, kq;

            Console.Write("Nhap so nguyen: ");
            a = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                kq = a * i;
                Console.WriteLine(a + " x " + i + " = " + kq);
            }
            Main();
        }

        /*
         * Bài tập 7 mở rộng: Cho phép người dùng nhập n số (kiếm tra có số lẻ ->
        nếu không dung bắt người dùng nhập lại, người dùng có thể nhập sai 3 lần ->
        Tính tổng của dãy số lẻ người dùng nhập vào.
         */
        void bai7()
        {
            int i, n, c = 0, sum = 0;
            Console.Write("Nhap so luong so le can tinh: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("----------------------------");

            for (i = 0; i < n; i++)
            {
                //Console.Write("Nhap so le thu " + i + ": ");
                //a[i] = Int32.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Nhap so le thu " + i + ": ");
                    a[i] = Int32.Parse(Console.ReadLine());
                    c++;
                }
                while (a[i]%2 == 0 && c <= 3);

                if (a[i] % 2 == 0 || c > 3)
                {
                    Console.WriteLine("Nhap sai so!");
                    Main();
                }

                sum = sum + a[i];
            }

            Console.WriteLine("Tong so le: " + sum);
            Main();
        }

        //8. Nhap 1 so va tim giai thua cua so do
        void bai8()
        {
            int i, f = 1, num;

            Console.Write("Nhap so nguyen: ");
            num = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("{0}!: {1}\n", num, f);
            Main();
        }

        static void Main()
        {
            Program a = new Program();
            int choice;
            Console.WriteLine("----Menu----");
            Console.WriteLine("1. Bai 1");
            Console.WriteLine("2. Bai 2");
            Console.WriteLine("3. Bai 3");
            Console.WriteLine("4. Bai 4");
            Console.WriteLine("5. Bai 5");
            Console.WriteLine("6. Bai 6");
            Console.WriteLine("7. Bai 7");
            Console.WriteLine("8. Bai 8");
            Console.WriteLine("9. Thoat chuong trinh");
            Console.Write("Chon bai: ");
            choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    a.bai1();
                    break;
                case 2:
                    a.bai2();
                    break;
                case 3:
                    a.bai3();
                    break;
                case 4:
                    a.bai4();
                    break;
                case 5:
                    a.bai5();
                    break;
                case 6:
                    a.bai6();
                    break;
                case 7:
                    a.bai7();
                    break;
                case 8:
                    a.bai8();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Khong co bai nay. Vui long chay lai he thong!!!");
                    break;
            }
        }
    }
}
