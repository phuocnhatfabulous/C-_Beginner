using System;
using System.Collections;
namespace buoi4
{
    //Gop chung voi class QLCB
    public class CanBo
    {
        public string Hoten;
        public short NamSinh;
        public string GioiTinh;
        public string DiaChi;
        public List<ThongTin> ListCongNhan = null;

        //Ham tao
        public CanBo()
        {    
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

        //Tim kiem cong nhan theo ten
        public List<CanBo> FindByName(String keyword)
        {
            List<CanBo> searchResult = new List<CanBo>();
            if (ListCongNhan != null && ListCongNhan.Count > 0)
            {
                foreach (CanBo sv in ListCongNhan)
                {
                    if (sv.Hoten.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }
    }
}
