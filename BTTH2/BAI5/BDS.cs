using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class BDS
    {
        protected string DiaDiem { get; set; }
        protected double GiaBan { get; set; }
        protected double DienTich { get; set; }
        protected virtual int Loai { get;  }

        public BDS() { 
            DiaDiem = string.Empty;
            GiaBan = 0;
            DienTich = 0;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap vao dia diem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap vao gia ban: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao dien tich: ");
            DienTich = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write($"Dia diem: {DiaDiem}, Gia ban: {GiaBan}, Dien tich: {DienTich}");
        }
        public virtual int getLoai()
        {
            return Loai;
        }
        public string getDiaDiem()
        {
            return DiaDiem;
        }
        public double getGiaBan()
        {
            return GiaBan;
        }
        public double getDienTich()
        {
            return DienTich;
        }
    }
}
