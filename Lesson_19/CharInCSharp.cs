using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_19
{
    public class CharInCSharp
    {
        public static void Main(string[] args)
        {
            // Kiểu kí tự trong C#
            char ch1 = 'a';
            Console.WriteLine(ch1.GetType().ToString());

            // Trong bảng mã ASCII
            char ch2 = (char)62;
            Console.WriteLine(ch2);

            // Ép kiểu char cho dữ liệu nhập vào
            char ch3 = char.Parse("a");
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());

            // Cách khác
            char ch4 = Convert.ToChar("g");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());

            // So sánh 2 ký tự
            char ch5 = 'a'; // 97
            char ch6 = 'b'; // 98
            char ch7 = 'a';
            Console.WriteLine(ch5.CompareTo(ch6)); // 97 - 98 = -1

            // So sánh 2 ký tự dùng Equals -> true, false
            Console.WriteLine(ch5.Equals(ch7)); // -> true
            Console.WriteLine(ch5.Equals(ch6)); // -> false


            // Các methods check
            // 1. Char.IsDigit(char) -> trả true false nếu là số
            // 2. Char.IsLetter(char) -> check chữ, trả true false
            // 3. Char.IsWhiteSpace(char) -> truyền vào space, trả true false
            // 4. Char.IsLower(char) -> true false, check chữ  in thường
            // 5. Char.IsUpper(char) -> true false, check chữ  in hoa
            // 6. Char.ToLower(char) -> chuyển chữ  in thường
            // 7. Char.ToUpper(char) -> chuyển chữ  in hoa
            // 1. Char.IsDigit(char) -> trả true false nếu là số
            Console.WriteLine("IsDigit: " + Char.IsDigit('5'));  // True

            // 2. Char.IsLetter(char) -> trả true false nếu là chữ
            Console.WriteLine("IsLetter: " + Char.IsLetter('A'));  // True

            // 3. Char.IsWhiteSpace(char) -> truyền vào space, trả true false
            Console.WriteLine("IsWhiteSpace: " + Char.IsWhiteSpace(' '));  // True

            // 4. Char.IsLower(char) -> trả true false, kiểm tra chữ thường
            Console.WriteLine("IsLower: " + Char.IsLower('b'));  // True

            // 5. Char.IsUpper(char) -> trả true false, kiểm tra chữ hoa
            Console.WriteLine("IsUpper: " + Char.IsUpper('C'));  // True

            // 6. Char.ToLower(char) -> chuyển chữ hoa thành chữ thường
            Console.WriteLine("ToLower: " + Char.ToLower('D'));  // d

            // 7. Char.ToUpper(char) -> chuyển chữ thường thành chữ hoa
            Console.WriteLine("ToUpper: " + Char.ToUpper('e'));  // E
        }
    }
}