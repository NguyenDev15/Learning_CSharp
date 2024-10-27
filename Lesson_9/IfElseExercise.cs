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


            // bài tập 06 
            // kiểm tra năm nhuận
            Console.Write("Nhập vào năm để kiểm tra: ");
            int year = int.Parse(Console.ReadLine());
            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
                Console.WriteLine("Đây là năm nhuận");
            }else{
                Console.WriteLine("Đây là năm không nhuận");
            }


            // bài tập 07 
            // Kiểm tra số ngày trong tháng
            Console.Write("Mời nhập vào tháng để kiểm tra ngày: ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Tháng {month} có 31 ngày!");
                break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Tháng {month} có 30 ngày!");
                break;

                case 2:
                    Console.Write("Nhập vào năm để kiểm tra: ");
                    int yearOfMonth2 = int.Parse(Console.ReadLine());
                    if(yearOfMonth2 % 4 == 0 && yearOfMonth2 % 100 != 0 || yearOfMonth2 % 400 == 0){
                        Console.WriteLine($"Năm {yearOfMonth2} - Tháng {month} có 29 ngày!");
                    }else{
                        Console.WriteLine($"Năm {yearOfMonth2} - Tháng {month} có 28 ngày!");
                    }
                break;
                default:
                    Console.WriteLine("Tháng không hợp lệ");
                break;
            }



        }
    }
}