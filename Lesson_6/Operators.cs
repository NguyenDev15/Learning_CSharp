using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class Operators
    {
        public static void Main(string[] args)
        {
            // Toán tử gán dùng để viết ngắn hơn khi lập trình
            int a = 1;
            int b = 2;
            b += a; // b = b + a;
            Console.WriteLine($"b = {b}");
            float x = 2.2f;
            float y = 4.1f;
            y *= x;
            Console.WriteLine($"y = {y}");

            // toán sử so sánh
            string str1 = "abc";
            string str2 = "abcd";
            if(str1 == str2){
                Console.WriteLine("ok");
            }else{
                Console.WriteLine("fail");
            }

            int u = 10;
            int o = 20;
            if(u >= o){
                Console.WriteLine("u = o");
            }else{
                Console.WriteLine("u != o");
            }

            // và nhiều toán tử so sánh khác nhau > , < , != , == ,... 

        }
    }
}