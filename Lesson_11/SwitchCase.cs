using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_11
{
    public class SwitchCase
    {
        public static void Main(string[] args)
        {
            // Switch Case bài tập vận dụng 11
            Console.WriteLine("CHƯƠNG TRÌNH TÌM KÍM");
            Console.WriteLine("1. Tìm theo tên");
            Console.WriteLine("2. Tìm theo tác giả");
            Console.WriteLine("3. Tìm theo tiêu đề");
            Console.WriteLine("4. Thoát");
            Console.Write("Mời chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Tìm theo tên");
                break;
                case 2:
                    Console.WriteLine("Tìm theo tấc giả");
                break;
                case 3:
                    Console.WriteLine("Tìm theo tiêu đề");
                break;
                case 4:
                    Console.WriteLine("Thoát");
                break;
                default:
                    Console.WriteLine("Không hợp lệ!");
                break;
            }
        }
    }
}