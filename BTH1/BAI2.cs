using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    internal class Program
    {
        static bool check(int x)
        {
            if(x < 2) return false;
            for (var i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;

            }
            return true;
        }
        static void Main()
        {
            int n;
            int sum = 0;
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            for (var i = 2; i < n; i++)
            {
                if (check(i)) sum += i;
            }
            Console.WriteLine($"Tong cac so nguyen to < n la {sum}");
            Console.ReadKey();
        }
       
    }
}
