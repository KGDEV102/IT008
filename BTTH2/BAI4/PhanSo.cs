using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Bai4
{
    internal class PhanSo
    {
        private int tu { get; set; }   
        private int mau { get; set; }    
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }

        public void Nhap()
        {
            Console.Write("Nhap vao tu: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao mau: ");
            mau = int.Parse(Console.ReadLine());
            while(mau == 0)
            {
                Console.WriteLine("Nhap lai mau (mau khac 0): ");
                mau = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
           if(mau == 1)
            {
                Console.Write($"{tu}");
            }else if(mau < 0 && tu < 0)
            {
                Console.Write($"{tu}/{mau}");
            }else if(mau < 0)
            {
                Console.Write($"-{tu}/{-mau}");
            }
            else
            {
                Console.Write($"{tu}/{mau}");
            }
        }
        public double GiaTri => (double)tu / mau;
        public PhanSo rutGon()
        {
            int gcd = (int)BigInteger.GreatestCommonDivisor(tu,mau);
            tu = tu / gcd;
            mau = mau / gcd;
            return this;
        }
        public override string ToString()
        {
            if (mau == 1) return $"{tu}";
            if (mau < 0 && tu < 0) return $"{tu}/{mau}";
            if (mau < 0) return $"-{tu}/{-mau}";
            return $"{tu}/{mau}";
        }


        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            res.mau = a.mau * b.mau;
            res.tu = a.tu * b.mau + b.tu * a.mau;
            res = res.rutGon();
            return res;
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            res.mau = a.mau * b.mau;
            res.tu = a.tu * b.mau - b.tu * a.mau;
            res = res.rutGon();
            return res;
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            res.mau = a.mau * b.mau;
            res.tu = a.tu * b.tu;
            res = res.rutGon();
            return res;
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo();
            res.tu = a.tu * b.mau;
            res.mau = a.mau * b.tu;
            res = res.rutGon();
            return res;
        }
    }
}

