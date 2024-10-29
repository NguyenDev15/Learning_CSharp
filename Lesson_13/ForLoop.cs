using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_13
{
    public class ForLoop
    {
        public static void Main(string[] args)
        {   
            // tính giai thừa với while Loop
            Console.Write("Mời nhập !x (while): ");
            int x = int.Parse(Console.ReadLine());
            int ii = 1;
            int gt = 1;
            while(ii <= x){
                gt *= ii;
                ii++;
            }
            Console.WriteLine($"!{x} = {gt}");

            // tính giai thừa với for Loop
            Console.Write("Mời nhập !n (for): ");
            int n = int.Parse(Console.ReadLine());
            int giaiThua = 1;
            for(int i = 1;i <= n; i++){
                giaiThua *= i; 
            }
            Console.WriteLine($"!{n} = {giaiThua}" );
        }
    }
}