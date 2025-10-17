using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void timMax(PhanSo[] arr)
        {
            PhanSo maxval = new PhanSo();
            double min = double.MinValue;
            foreach(PhanSo p in arr)
            {
               if(p.GiaTri > min)
                { 
                    min = p.GiaTri;
                    maxval = p;
                }
            }
            Console.Write($"Phan so lon nhat la: ");
            maxval.Xuat();
            Console.WriteLine();
        }
        static void sapXep(PhanSo[] arr)
        {
            List<PhanSo> lst = arr.ToList();
            lst.Sort((a,b) => a.GiaTri.CompareTo(b.GiaTri));
            Console.Write("Day phan so sau khi sap xep tang dan: ");
            foreach(PhanSo p in lst)
            {
                p.Xuat();
                Console.Write(" ");
            }
        }
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            Console.WriteLine("Nhap vao phan so thu nhat: ");
            a.Nhap();
            Console.WriteLine("Nhap vao phan so thu hai: ");
            b.Nhap();
            PhanSo res1 = a + b;
            PhanSo res2 = a - b;
            PhanSo res3 = a * b;
            PhanSo res4 = a / b;

            Console.WriteLine($"{a} + {b} = {res1}");
            Console.WriteLine($"{a} - {b} = {res2}");
            Console.WriteLine($"{a} * {b} = {res3}");
            Console.WriteLine($"{a} / {b} = {res4}");

            Console.WriteLine("Nhap vao so luong phan so: ");
            int n;
            n = int.Parse( Console.ReadLine());
            PhanSo[] arr = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan so thu {i + 1}:");
                arr[i] = new PhanSo();
                arr[i].Nhap();
            }

            timMax(arr);
            sapXep(arr);

        }
    }
}
