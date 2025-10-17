using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyKhuDat ql = new QuanLyKhuDat();
            ql.Nhap();
            ql.Xuat();
            ql.TongGia();
            ql.Xuat1();
            ql.TimKiem();
        }
    }
}
