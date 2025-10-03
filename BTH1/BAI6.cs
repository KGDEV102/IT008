using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Xuat(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        static void find1(int[,] arr){
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   if(arr[i, j] < min) min = arr[i, j];
                   if(arr[i, j] > max) max = arr[i, j];
                }
            }
            Console.WriteLine($"Phan tu lon nhat {max}");

            Console.WriteLine($"Phan tu nho nhat {min}");
        }
        static void find2(int[,] arr)
        {
            double maxval = int.MinValue;
            int maxcol = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum+= arr[i, j];
                }
                if (sum > maxval)
                {
                    maxcol = i;
                    maxval = sum;
                }
                
            }
            Console.WriteLine($"Dong co tong lon nhat la {maxcol + 1}");

        }
        static bool checknt(int x)
        {
            if(x<2) return false;
            for(var i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void sum(int[,] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(!checknt(arr[i, j])) sum+= arr[i, j];
                }
                
            }
            Console.WriteLine($"Tong cac so khong phai so nguyen to la {sum}");
        }
        static int[,] deleterow( int[,] arr, int k)
        {
           
            int[,] newarr = new int[arr.GetLength(0)-1,arr.GetLength(1)];
            for (int i = 0;i < k; i++)
            {
                for (int j=0;j < arr.GetLength(1); j++)
                {
                    newarr[i,j] = arr[i,j];
                }
            }
            for (int i = k+1; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newarr[i-1, j] = arr[i, j];
                }
            }

            return newarr;

        }
        static int[,] deletecol(int[,] arr)
        {
            int max = int.MinValue;
            int maxcol = 0;
            int[,] newarr = new int[arr.GetLength(0),arr.GetLength(1)-1];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxcol = j;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int colIdx = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    if (j == maxcol) continue;
                    newarr[i,colIdx] = arr[i, j];
                    colIdx++;
                }
            }
           
            return newarr;
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Nhap vao so dong: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so cot: ");
            m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n,m];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rd.Next(1,101);
                }
            }

            Xuat(arr);
            find1(arr);
            find2 (arr);
            sum(arr);
            int k;
            Console.Write("Nhap vao dong k muon xoa: (k>=0)");
            k = int.Parse(Console.ReadLine());
            int [,] newarr1 = deleterow(arr, k);
            Console.WriteLine($"Ma tran sau khi xoa dong {k}: ");
            for(var i = 0; i < newarr1.GetLength(0); i++)
            {
                for(var j = 0; j < newarr1.GetLength(1); j++)
                {
                    Console.Write(newarr1[i,j] + "\t");
                }
                Console.WriteLine();
            }

            int [,] newarr2 = deletecol(arr);
            Console.WriteLine($"Ma tran sau khi xoa cot chua phan tu lon nhat: ");
            for (var i = 0; i < newarr2.GetLength(0); i++)
            {
                for (var j = 0; j < newarr2.GetLength(1); j++)
                {
                    Console.Write(newarr2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
