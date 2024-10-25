using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class ConstAndCaculators
    {
        public static void Main(string[] args)
        {
            // Hằng số (không thể thay đổi sau khi đã khởi tạo)
            const int doSoi = 100;
            const int doDong = 0;
            const float PI = 3.14f;

            Console.WriteLine("PI = " + PI);

            // Phép tính cơ bản
            float x,y;
            Console.Write("Mời nhập vào x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Mời nhập vào y: ");
            y = float.Parse(Console.ReadLine());
            
            float z1 = x + y;
            float z2 = x - y;
            float z3 = x * y;
            float z4 = x / y;
            float z5 = x % y;

            Console.WriteLine($"{x} + {y} = " + z1);
            Console.WriteLine($"{x} - {y} = " + z2);
            Console.WriteLine($"{x} * {y} = " + z3);
            Console.WriteLine($"{x} / {y} = " + z4);
            Console.WriteLine($"{x} % {y} = " + z5);

            Console.WriteLine();
            // Bài tập cơ bản về các phép tính
            int i1 = 1;
            int i2 = 5;
            int i3 = -3;
            double d1 = 2.0;
            double d2 = 5.0;
            double d3 = -0.5;

            Console.WriteLine($"{i1} + ({i2} * {i3}) = {i1 + (i2 * i3)}");
            Console.WriteLine($"{i1} / ({i2} + {i3}) = {(float) i1 / (i2 + i3)}");
            Console.WriteLine($"({d1} + {d2} + {d3}) / 3 = {(d1 + d2 + d3) / 3}");
            Console.WriteLine($"{d1} + {d2} * {d3} = {d1 + d2 * d3}");
        }
    }
}