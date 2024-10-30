using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_17
{
    public class RandomInCSharp
    {
        public static void Main(string[] args)
        {
            // cú pháp tạo 1 đối tượng có thể sinh ra số random
            Random rd = new Random();

            // random ngãu nhiên
            int soRandom = rd.Next(50,101); // re.Next(Begin,end - 1);
            Console.WriteLine("Số ngẫu nhiên = " + soRandom);
        }
    }
}