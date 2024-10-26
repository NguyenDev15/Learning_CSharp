using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class PrefixPostPixAndOperatorLogic
    {
        public static void Main(string[] args)
        {
            // Toán tử Logic
            // && khi tất cả điều kiện đều true thì mới true
            // || chỉ cần một điều kiện đúng thì vẫn trả true
            // ! phủ định
            // ?: gần như if else và thường thấy ở toán tử 3 ngôi

            int a = 10;
            int b = 5;
            bool check1 = (a != b) || (a < 3); // 1 đúng 1 sai => True
            bool check2 = ((a > b) && (a == b));
            Console.WriteLine($"Check1 = " + check1);
            Console.WriteLine($"Check2 = " + check2);


            // Tiền Tố, Hậu Tố (Prefix, PostFix) x++ ++x
            // Tính ưu tiên
            // 1. Prefix 
            // 2. Các phép toán khác
            // 3. Gán giá trị bên trái dấu =
            // 4. Postix
            int x = 1; int y = 2;
            int kq = x++ - ++y + 1; // kq = 1 - 3 + 1 = -1
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"kq = {kq}");


            // Bài tập vận dụng 03
            Console.Write("Nhập vào chiều dài hcn: ");
            float chieuDai = float.Parse(Console.ReadLine());
            Console.Write("Nhập vào chiều rộng hcn: ");
            float chieuRong = float.Parse(Console.ReadLine());

            float dienTichHcn = chieuDai * chieuRong;
            float chuViHcn = (chieuDai + chieuRong) * 2;

            Console.WriteLine("Diện tích hình chữ nhật = " + dienTichHcn);
            Console.WriteLine("Chu vi hình chữ nhật = " + chuViHcn);
            
        }
    }
}