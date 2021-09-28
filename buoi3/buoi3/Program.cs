using System;

namespace buoi3
{
    //VD1
    class Box
    {
        //Declare variable
        public double chieu_dai;
        public double chieu_rong;
        public double chieu_cao;
    }
    //VD2 ke thua
    class Shape
    {
        protected int CR;
        protected int CC;
        protected int CD;

        public void setCR(int w)
        {
            CR = w;
        }
        public void setCC(int h)
        {
            CC = h;
        }
        public void setCD(int l)
        {
            CD = l;
        }
    }
    class Rectangle : Shape
    {
        public int TinhDienTich()
        {
            return (CC * CR);
        }
    }
    //VD3 ke thua
    class HCN
    {
        protected int CR;
        protected int CC;

        public HCN(int l, int w)
        {
            CC = l;
            CR = w;
        }
        public int TinhDienTich()
        {
            return (CC * CR);
        }
    }
    class ChiPhiXayDung : HCN
    {
        private double cost;
        public ChiPhiXayDung(int w, int l) : base(w, l)
        { }
        public double TinhChiPhi()
        {
            double ChiPhi;
            ChiPhi = TinhDienTich() * 70;
            return ChiPhi;
        }
    }
    //VD4 ke thua
    class Hinh
    {
        protected int CR;
        protected int CC;

        public void setCR(int w)
        {
            CR = w;
        }
        public void setCC(int h)
        {
            CC = h;
        }
    }
    public interface ChiPhiSon
    {
        int TinhChiPhiSon(int DienTich);
    }
    class HinhChuNhat : Hinh, ChiPhiSon
    {
        public int TinhDienTich()
        {
            return (CR * CC);
        }
        public int TinhChiPhiSon(int DienTich)
        {
            return DienTich * 70;
        }
    }
    //VD6
    class HinhHoc
    {
        protected int CC, CD;

        public HinhHoc(int a = 0, int b = 0)
        {
            CC = a;
            CD = b;
        }
        public virtual int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class cha: ");
            return 0;
        }
        
    }
    class HinhChuNhat1 : HinhHoc
    {
        public HinhChuNhat1(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class hcn: ");
            return (CC * CD);
        }
    }
    class TamGiac : HinhHoc
    {
        public TamGiac(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class tam giac: ");
            return ((CC*CD)/2);
        }
    }
    class HienThiDuLieu
    {

    }
    //Class Main
    public class TestCsharp
    {
        //VD5 da hinh
        void print(int i)
        {
            Console.WriteLine("In so nguyen: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("In so thuc: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("In chuoi: {0}", s);
        }
        static void Main(string[] args)
        {
            //VD1
            Console.WriteLine("-----------------");
            Rectangle b = new Rectangle();
            b.setCC(3);
            b.setCR(4);
            Console.WriteLine("Dien tich hinh chu nhat: {0}", b.TinhDienTich());
            //VD2
            Box a = new Box();
            double TheTich = 0.0;

            a.chieu_dai = 2.2;
            a.chieu_rong = 3.3;
            a.chieu_cao = 5.5;

            TheTich = a.chieu_rong * a.chieu_dai * a.chieu_cao;
            Console.WriteLine("The tich cua box la: {0}", TheTich);
            //VD3
            ChiPhiXayDung c = new ChiPhiXayDung(7,8);

            Console.WriteLine("Chi phi: {0}", c.TinhChiPhi());
            //VD4
            HinhChuNhat d = new HinhChuNhat();
            d.setCC(4);
            d.setCR(5);
            int DienTich = d.TinhDienTich();
            Console.WriteLine("Dien tich hcn: {0}", d.TinhDienTich());
            Console.WriteLine("Chi phi son: {0}", d.TinhChiPhiSon(DienTich));
            //VD5
            TestCsharp e = new TestCsharp();
            e.print(2);
            e.print(2.3);
            e.print("Phuoc Nhat");
            //VD6
            Console.ReadKey();

        }
    }
}
