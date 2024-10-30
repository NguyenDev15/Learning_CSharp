using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_16
{
    public class MathLibrary
    {
        public static void Main(string[] args)
        {
            // Các hàm toán học
            // PI
            Console.WriteLine("Pi = " + Math.PI);
            Console.WriteLine("Kiểu dữ liệu của Math.PI = " + Math.PI.GetType().ToString());

            // Căn bậc 2
            Console.WriteLine("Căn bậc 2 của 2 = " + Math.Sqrt(4));

            // Lũy thừa
            Console.WriteLine("2 mũ 3 = " + Math.Pow(2,3));

            // Max - Min
            Console.WriteLine("Max = " + Math.Max(2,3));
            Console.WriteLine("Min = " + Math.Min(2,3));

            // Làm tròn
            float c = 1.25354453f;
            Console.WriteLine($"Số {c} khi làm tròn 2 chữ số = " + Math.Round(c,2));
        }
    }
}