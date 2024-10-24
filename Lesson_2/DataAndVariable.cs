using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_2
{
    public class DataAndVariable
    {
        public static void Main(string[] args)
        {
            // các kiểu in
            int a = 1;
            string b = "C Sharp";
            Console.WriteLine("a = " + a); 
            Console.WriteLine("a = {0}",a); 
            Console.WriteLine($"b = {b}");
            
            // Quy tắc đặt tên biến (không dùng kí tự đặc biệt)
            float diemSo = 8.5f;
            int diemTb = 5;

            // ép kiểu từ bé sang lớn(nếu ngược lại -> lỗi)
            int x = 10;
            int y = 11;
            float z1 = x /y;
            float z2 = (float)x / y;
            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 =" + z2);
            
        }
    }
}