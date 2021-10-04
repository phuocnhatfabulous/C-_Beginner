using System;
using System.Collections.Generic;

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
                        a.NhapTT();
                        break;
                    case 2:
                        if (a.SoLuongCN() > 0)
                        {
                            Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                            Console.Write("\nNhap ten de tim kiem: ");
                            string hoten = Convert.ToString(Console.ReadLine());
                            List<ThongTin> searchResult = a.TimKiem(hoten);
                            a.ShowCongNhan(searchResult);
                        }
                        break;
                    case 3:
                        a.HienThi();
                        break;
                    case 4:
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
