using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class NhaPho:BDS
    {
        private int NamXD { get; set; }
        private int SoTang { get; set; }
        
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nam xay dung: ");
            NamXD = int.Parse(Console.ReadLine());
            Console.Write("So tang: ");
            SoTang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write($", Nam xay dung: {NamXD}, So tang: {SoTang}");
            
        }
        public override int getLoai()
        {
            return 1;
        }
        public int getNamXD()
        {
            return NamXD;
        }
        public int getSoTang()
        {
            return SoTang;
        }

    }
}
