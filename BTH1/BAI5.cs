using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            Console.Write("Nhap vao ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao nam: ");
            nam = int.Parse(Console.ReadLine());
            try
            {
                DateTime dt = new DateTime(nam,thang,ngay);
                DayOfWeek thu = dt.DayOfWeek;
                Console.WriteLine($"{ngay}/{thang}/{nam} thuoc  {thu}");
            }
            catch
            {
                Console.WriteLine("Ngay, thang, nam khong hop le");
            }
            Console.ReadKey();
        }
    }
}
