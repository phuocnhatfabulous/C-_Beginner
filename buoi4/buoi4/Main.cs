using System;

namespace buoi4
{
    class main
    {
        static void Main(string[] args)
        {
            int choice = 0;
            CanBo a = new CanBo();
            do
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1. Nhap thong tin moi cho can bo.");
                Console.WriteLine("2. Tim kiem theo ho ten.");
                Console.WriteLine("3. Hien thi thong tin ve danh sach cac can bo.");
                Console.WriteLine("4. Thoat.");
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
            } while (choice < 4);
        }
    }
}
