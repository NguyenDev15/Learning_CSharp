using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_9
{
    public class IfElseExercise
    {
        public static void Main(string[] args)
        {
            // Bài tập 04
            // Tìm x y khi cho tổng và hiệu
            Console.Write("Nhập tổng 2 số: ");
            double tong = double.Parse(Console.ReadLine());
            Console.Write("Nhập hiệu 2 số: ");
            double hieu = double.Parse(Console.ReadLine());

            double x = (tong + hieu) / 2;
            double y = tong - x;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            // bài tập 05
            // tính bmi
            Console.Write("Nhập cân nặng (kg): ");
            float canNang = float.Parse(Console.ReadLine());

            Console.Write("Nhập chiều cao (m): ");
            float chieuCao = float.Parse(Console.ReadLine());

            float bmi = canNang / (chieuCao * chieuCao);
            Console.WriteLine($"BMI của bạn là: {bmi}");

            if (bmi < 15)
            {
                Console.WriteLine("Quá gầy");
            }
            else if (bmi >= 15 && bmi < 16)
            {
                Console.WriteLine("Hơi hơi gầy");
            }
            else if (bmi >= 16 && bmi < 18.5)
            {
                Console.WriteLine("Gầy nhẹ");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Bình thường");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Hơi béo");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("Béo");
            }
            else
            {
                Console.WriteLine("Béo phì rồi");
            }


            // bài tập 05 
            // kiểm tra năm nhuận
            Console.Write("Nhập vào năm để kiểm tra: ");
            int year = int.Parse(Console.ReadLine());
            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
                Console.WriteLine("Đây là năm nhuận");
            }else{
                Console.WriteLine("Đây là năm không nhuận");
            }
        }
    }
}