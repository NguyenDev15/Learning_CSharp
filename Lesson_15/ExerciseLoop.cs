using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_15
{
    public class ExerciseLoop
    {
        public static void Main(string[] args)
        {
            // bài tập 12
            // tính giai thừa với while Loop 
            Console.Write("Mời nhập !x (while): ");
            int n1 = int.Parse(Console.ReadLine());
            int ii = 1;
            int gt = 1;
            while(ii <= n1){
                gt *= ii;
                ii++;
            }
            Console.WriteLine($"!{n1} = {gt}");
            // tính giai thừa với for Loop
            Console.Write("Mời nhập !n (for): ");
            int n2 = int.Parse(Console.ReadLine());
            int giaiThua = 1;
            for(int i = 1;i <= n2; i++){
                giaiThua *= i; 
            }
            Console.WriteLine($"!{n2} = {giaiThua}" );

            // bài tập 13
            // tính tổng các số chẵn
            Console.Write("Xin mời nhập số nguyên: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n3 % 2 == 0)
            {
                int sum = 0;
                for (int i = 0; i <= n3; i += 2)
                {
                    sum += i;
                }
                Console.WriteLine($"Tổng các số chẵn = {sum}");
            }
            else
            {
                Console.WriteLine("Tôi không tính số lẻ bái bai");
            }

            // bài tập 14
            Console.Write("Xin mời nhập số lẻ: ");
            int n4 = int.Parse(Console.ReadLine());

            int soLe = 0;
            for (int i = 0; i <= n4; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == 3)
                    {
                        continue;
                    }
                    soLe += i;
                }
            }

            Console.WriteLine($"Tổng các số lẻ = {soLe}"); 


            // bài tập 16
            // tính tổng các giai thừa
            Console.Write("Xin mời nhập số nguyên n: ");
            int n5 = int.Parse(Console.ReadLine());

            int sum2 = 0;

            for (int i = 1; i <= n5; i++)
            {
                int giaiThua2 = 1;
                for (int j = 1; j <= i; j++)
                {
                    giaiThua2 *= j;
                }
                sum2 += giaiThua2;
            }

            Console.WriteLine($"Tổng S = {sum2}");

            // Bài tập 17
            // tìm số hoàn hảo 1 - 1000
             Console.Write("Xin mời nhập 1 số từ 1 đến 1000: ");
            int n6 = int.Parse(Console.ReadLine());
            int sum3 = 0;
            for (int i = 1; i < n6; i++)
            {
                if (n6 % i == 0)
                {
                    sum3 += i;
                }
            }

            if (sum3 == n6)
            {
                Console.WriteLine($"{n6} là số hoàn hảo");
            }
            else
            {
                Console.WriteLine($"{n6} không là số hoàn hảo");
            }
        }
    }
}