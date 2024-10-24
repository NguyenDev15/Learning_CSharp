using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class VarCSharp
    {
        public static void Main(string[] args)
        {
            // var trong C#

            var a = 1;
            Console.WriteLine($"a = {a.GetType().ToString()}");

            var b = "abc";
            Console.WriteLine($"b = {b.GetType().ToString()}");

            var c = 1.2; // tự cấp phát thành double
            Console.WriteLine($"c = {c.GetType().ToString()}");
        }
    }
}