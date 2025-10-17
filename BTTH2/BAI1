using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao thang: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao nam: ");
            int year = int.Parse(Console.ReadLine());

            //Tạo ngày đầu tiên của tháng
            DateTime firtDay = new DateTime(year, month, 1);
            
            //Lấy ra thứ của ngày đầu tiên
            DayOfWeek startDay = firtDay.DayOfWeek;

            //Lấy ra chỉ số của thứ
            int startIndex = (int)startDay;

            //Lấy ra ngày của tháng
            int daysInMonth = DateTime.DaysInMonth(year, month);

            int[,] calendar = new int[6, 7];

            int day = 1;
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if (i == 0 && j < startIndex) continue;
                    if(day <= daysInMonth)
                    {
                        calendar[i,j]= day;
                        day++;
                    }
                }  
            }

            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (calendar[i, j] == 0)
                        Console.Write("    "); 
                    else
                        Console.Write($"{calendar[i, j],3} ");
                }
                Console.WriteLine();
            }

        }
    }
}
