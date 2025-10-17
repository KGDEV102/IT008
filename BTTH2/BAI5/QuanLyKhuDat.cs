using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class QuanLyKhuDat
    {
        private int SoLuong { get; set; }
        private BDS[] DanhSach { get; set; }
        public QuanLyKhuDat() { 
            SoLuong = 0;
            DanhSach = null;
        }
        public void Nhap()
        {
            Console.Write("Nhap vao so luong cua danh sach can quan ly: ");
            SoLuong = int.Parse(Console.ReadLine());
            DanhSach = new BDS[SoLuong];
            for(int i = 0; i < DanhSach.Length; i++)
            {
                Console.Write("Nhap vao loai kinh doanh can quan ly (0. Khu Dat, 1. Nha Pho, 2. Chung Cu): ");
                int x;
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    DanhSach[i] = new KhuDat();
                }
                else if (x == 1)
                {
                    DanhSach[i] = new NhaPho();
                }
                else
                {
                    DanhSach[i] = new ChungCu();
                }
                DanhSach[i].Nhap();
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Danh sach thong tin quan ly ");
            for(int i = 0;i < DanhSach.Length; i++)
            {

                DanhSach[i].Xuat();
                Console.WriteLine();
            }
        }
        public void TongGia()
        {
            double sum = 0;
            foreach(var item in DanhSach)
            {
                sum += item.getGiaBan();
            }
            Console.WriteLine($"Tong gia ban: {sum}");
        }
        public void Xuat1()
        {
            Console.WriteLine("Danh sach cac BDS thoa dieu kien: ");
            bool check = false;
            foreach(var item in DanhSach)
            {
                if(item.getLoai() == 0 && item.getDienTich() > 100)
                {
                    check = true;
                    item.Xuat();
                    Console.WriteLine();
                }else if(item.getLoai() == 1)
                {
                    var nha = item as NhaPho;
                    if(nha.getDienTich() > 60 && nha.getNamXD() >= 2019)
                    {
                        check=true;
                        item.Xuat();
                        Console.WriteLine();
                    }
                }
            }
            if(!check) Console.WriteLine("Khong co BDS nao thoa dieu kien");
        }
        public void TimKiem()
        {
            string DiaDiem = String.Empty;
            double Gia = 0;
            double DienTich = 0;
            Console.WriteLine();
            Console.Write("Nhap vao Dia diem: ");
            DiaDiem = Console.ReadLine();

            Console.Write("Nhap vao Gia: ");
            Gia = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao Dien tich: ");
            DienTich = double.Parse(Console.ReadLine());
            bool check = false;
            Console.WriteLine("Danh sach cac Nha Pho, Chung Cu tim thay: ");
            foreach (var item in DanhSach)
            {
                if(item.getLoai() == 1 || item.getLoai() == 2)
                {
                    if(item.getDiaDiem().ToUpper() == DiaDiem.ToUpper() && item.getGiaBan() <= Gia && item.getDienTich() >= DienTich)
                    {
                        check=true;
                        item.Xuat();
                        Console.WriteLine();
                    }
                }
            }
            if (!check) Console.WriteLine("Khong tim thay Nha Pho hoac Chung Cu nao");
        }
    }
}
