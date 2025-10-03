using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //a. Tính tổng các số lẻ
        static double sum(int[] arr)
        {
            double sum = 0;
            foreach(var i in arr)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        //Hàm kiểm tra số nguyên tố
        static bool check1(int x)
        {
            if (x < 2) return false;
            for(int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        //b. Đếm số nguyên tố
        static int cnt(int[] arr)
        {
            int cnt = 0;
            foreach(var i in arr)
            {
                if(check1(i)) cnt++;

            }
            return cnt;
        }

        //Hàm kiểm tra số chính phương
        static bool check2(int x)
        {
            if(x<0) return false;
             int k = (int)Math.Sqrt(x);
    return k * k == x;
        }

        //c. Tìm số chính phương nhỏ nhất 
        static int find(int[] arr)
        {
            int res = int.MaxValue;
            foreach (var i in arr)
            {
                if (check2(i) && i < res) res = i;
            }
            if (res == int.MaxValue) return -1;
            return res;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so luong phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rd.Next(-100,100);
            }
            Console.Write("Mang vua tao: ");
            foreach (var i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cac so le trong mang {sum(arr)}");
            Console.WriteLine($"So nguyen to trong mang {cnt(arr)}");
            if (find(arr) != -1) Console.WriteLine($"So chinh phuong nho nhat trong mang la {find(arr)}");
            else Console.WriteLine("Mang khong co so chinh phuong");
        }
    }
}
