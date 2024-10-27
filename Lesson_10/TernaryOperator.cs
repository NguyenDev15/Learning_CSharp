using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_10
{
    public class TernaryOperator
    {
        public static void Main(string[] args)
        {
            // Toán tử 3 ngôi (bản chất của if else)
            Console.Write("Mời nhập số kiểm tra chẵn lẻ: ");
            int a = int.Parse(Console.ReadLine());
            
            string kq = (a % 2 == 0) ? "Chẵn" : "Lẻ";

            Console.WriteLine(kq);


            // bài tập 10
            // Dùng toán tử 3 ngôi để xếp loại học lực
            Console.Write("Mời nhập điểm trung bình: ");
            float diemTb = float.Parse(Console.ReadLine());

            string xepLoai = (diemTb >= 8) ? "Giỏi" :
                             (diemTb >= 6.5) ? "Khá" :
                             (diemTb >= 5) ? "Trung bình" : "Yếu";

            Console.WriteLine(xepLoai);
        }   
    }
}