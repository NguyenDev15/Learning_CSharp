using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_12
{
    public class DoWhileAndWhileLoop
    {
        public static void Main(string[] args)
        {
            // Vòng lặp Do While
            // Do: thực hiện cv trong Loop
            // While: điều kiện lặp

            int x = 0;
            do
            {
                Console.WriteLine($"x = {x}");
                x++;
            } while (x  <= 5);

            // while Loop
            // Viết ctr nhập vào n 
            // n chỉ trong 1 đến 99
            // Nhập sai nhập lại
            Console.Write("Mời nhập vào n (1 - 99): ");
            int n = int.Parse(Console.ReadLine());

            while(n < 1 || n > 99){
                Console.Write("n chỉ từ 1 đến 99! Nhập lại: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhập n xong, n = " + n);

            // While(true) -> chạy vô hạn đến khi thỏa mãn điều kiện thì thoát
            int wTrue;
            while(true){
                n++;
                Console.WriteLine("n = " + n);
                if(n == 5){
                    break;
                }
            }

        }
    }
}