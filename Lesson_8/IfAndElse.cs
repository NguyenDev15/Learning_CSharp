using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class IfAndElse
    {
        public static void Main(string[] args)
        {
            // If Else (Điều kiện)

            Console.Write("Nhập vào điểm tốt nghiệp: ");
            float diemTn = float.Parse(Console.ReadLine());
            if(diemTn >= 5 && diemTn <= 10){
                Console.WriteLine($"Bạn đã tốt nghiệp! điểm của bạn là {diemTn}");
            }else{
                Console.WriteLine("Rớt tốt nghiệp!");
            }

        }
    }
}