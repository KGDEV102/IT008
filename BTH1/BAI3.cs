using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static bool isNhuan(int nam)
        {
            if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0)) return true;
            return false;
        }
        static int dayofmonth(int thang,int nam)
        {
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                case 4: case 6: case 9: case 11:
                    return 30;
                case 2:
                    if (isNhuan(nam)) return 29;
                    return 28;

            }
            return -1;
        }
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            Console.Write("Nhap vao ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao nam: ");
            nam = int.Parse(Console.ReadLine());
            bool res = true;
            if(thang < 1 || thang > 12) res =  false;
            else if(ngay < 1 || ngay > dayofmonth(thang, nam)) res = false;
            if (res) Console.WriteLine("Ngay, thang, nam hop le!");
            else Console.WriteLine("Ngay, thang, nam khong hop le!");

        }
    }
}
