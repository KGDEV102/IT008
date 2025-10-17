using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao duong dan thu muc: ");
            string path = Console.ReadLine();

           
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Thư mục không tồn tại!");
                return;
            }

            Console.WriteLine($"\nDirectory of {path}\n");

            // Lấy danh sách thư mục con
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                DirectoryInfo d = new DirectoryInfo(dir);
                Console.WriteLine($"{d.LastWriteTime:dd/MM/yyyy hh:mm tt}    <DIR>    {d.Name}");
            }

            // Lấy danh sách tập tin
            string[] files = Directory.GetFiles(path);
            long totalSize = 0;
            foreach (string file in files)
            {
                FileInfo f = new FileInfo(file);
                Console.WriteLine($"{f.LastWriteTime:dd/MM/yyyy hh:mm tt}    {f.Length,10:N0}    {f.Name}");
                totalSize += f.Length;
            }

            // Tổng kết
            Console.WriteLine($"\n  {files.Length} File(s)   {totalSize:N0} bytes");
            Console.WriteLine($"  {dirs.Length} Dir(s)\n");
        }
    }
}
