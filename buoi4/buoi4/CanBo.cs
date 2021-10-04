using System;
using System.Collections;
using System.Collections.Generic;

namespace buoi4
{
    //Gop chung voi class QLCB
    public class CanBo
    {
        public string Hoten;
        public short NamSinh;
        public string GioiTinh;
        public string DiaChi;
        private List<ThongTin> ListCongNhan = null;

        //Ham tao
        public CanBo()
        {
            ListCongNhan = new List<ThongTin>();
        }

        //Nhap thong tin ca nha
        public void NhapTT()
        {
            Console.Write("Nhap ho va ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = Convert.ToInt16(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
        }

     

        //Hien thi thong tin ca nhan
        public void HienThi()
        {
            Console.WriteLine("Ho ten: "+ Hoten);
            Console.WriteLine("Sinh nam: "+ NamSinh);
            Console.WriteLine("Gioi tinh: "+ GioiTinh);
            Console.WriteLine("Dia chi: "+ DiaChi);
        }

        public int SoLuongCN()
        {
            int Count = 0;
            if (ListCongNhan != null)
            {
                Count = ListCongNhan.Count;
            }
            return Count;
        }
        //Tim kiem cong nhan theo ten
        public List<ThongTin> TimKiem(String keyword)
        {
            List<ThongTin> searchResult = new List<ThongTin>();
            if (ListCongNhan != null && ListCongNhan.Count > 0)
            {
                foreach (ThongTin wk in ListCongNhan)
                {
                    if (wk.HoTen.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(wk);
                    }
                }
            }
            return searchResult;
        }
        public void ShowCongNhan(List<ThongTin> listCN)
        {
            // hien thi danh sach sinh vien
            if (listCN != null && listCN.Count > 0)
            {
                foreach (ThongTin wk in listCN)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5}",
                                      wk.HoTen, wk.NamSinh, wk.GioiTinh, wk.DiaChi);
                }
            }
            Console.WriteLine();
        }
    }
}
