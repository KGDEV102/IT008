using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class ChungCu: BDS
    {
        private int SoTang { get; set; }
       
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So tang: ");
            SoTang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write($", So tang: {SoTang}");
        }
        public override int getLoai()
        {
            return 2;
        }
        public int getSoTang()
        {
            return SoTang;
        }
    }
}
