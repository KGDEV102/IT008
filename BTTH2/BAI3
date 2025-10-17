using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void nhap(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}]: ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                   
                }
            }
        }
        static void xuat(int[,]arr)
        {
            for(int i = 0; i < arr.GetLength(0) ; i++)
            {
                for(int j=0; j < arr.GetLength(1) ; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void find(int[,] arr,int x)
        {
            bool res = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   if(arr[i,j] == x) res = true;
                   
                }
               
            }
            if (res)
            {
                Console.WriteLine($"{x} ton tai trong ma tran !");
            }
            else
            {
                Console.WriteLine($"{x} khong ton tai trong ma tran !");
            }
        }
        static bool isPrime(int x)
        {
            if(x < 2) return false;
            for(int i = 2; i <= Math.Sqrt(x); i++)
            {
                if(x % i == 0) return false;
            }
            return true;
        }
        static void XuatNT(int[,] arr)
        {
            bool check = false;
            for(int i=0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (isPrime(arr[i, j]))
                    {
                        Console.Write(arr[i, j] + " ");
                        check = true;
                    }
                }
            }
            Console.WriteLine();
            if(!check) Console.WriteLine("Ma tran khong ton tai so nguyen to");
        }

        static void rowMax(int[,] arr)
        {
            int max = 0;
            List<int> rowMax = new List<int>(); 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int cnt = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (isPrime(arr[i, j]))
                    {
                        ++cnt;
                    }
                }
                if(cnt >= max && cnt!=0)
                {
                    max = cnt;
                    rowMax.Add(i);
                }
            }
            if (rowMax.Count > 0) {
                Console.Write("Hang ");
                foreach (int i in rowMax) Console.Write(i + " ");
                Console.WriteLine("co nhieu so nguyen to nhat");
            } 
            else Console.WriteLine("Khong co hang nao ton tai so nguyen to");
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Nhap vao so hang cua ma tran: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so cot cua ma tran: ");
            m = int.Parse(Console.ReadLine());
            int[,]arr = new int[n, m];
            nhap(arr);
            xuat(arr);

            int x;
            Console.WriteLine("Nhap vao so can tim: ");
            x = int.Parse(Console.ReadLine());
            find(arr, x);
            Console.Write("Cac so nguyen to trong ma tran: ");
            XuatNT(arr);
            
            rowMax(arr);

        }
    }
}
