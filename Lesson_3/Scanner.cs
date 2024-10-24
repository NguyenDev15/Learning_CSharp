using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_3
{
    public class Scanner
    {
        public static void Main(string[] args)
        {
            // Dữ liệu từ người dùng nhập vào
            Console.Write("Nhập vào họ tên: "); // không xuống dòng khi nhập
            string hoTen = Console.ReadLine();
            Console.Write("Nhập vào điểm toán: ");
            float diemToan = float.Parse(Console.ReadLine()); // chuyển kiểu dữ liệu
            Console.Write("Nhập vào điểm văn: ");
            float diemVan = float.Parse(Console.ReadLine()); // chuyển kiểu dữ liệu

            Console.WriteLine($"Học sinh tên {hoTen}:");
            Console.WriteLine($"Văn = {diemVan}");
            Console.WriteLine($"Toán = {diemToan}");
        }
    }
}