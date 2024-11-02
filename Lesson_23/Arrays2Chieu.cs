using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_23
{
    public class Arrays2Chieu
    {
        public static void Main(string[] args)
        {
            // Mảng 2 chiều là tập hợp của mảng 1 chiều cùng kích thước
            // int[,] arr = new int[số hàng, số cột]
            
            // 1. khởi tạo mảng 2 chiều
            int[,] arr = new int[3,5]; // hàng 3 cột 5
            
            // 2. khởi tạo và gán
            int[,] arr2 = { {1,2,4} , {6,8,3} }; // khởi tạo gọn

            // 3. Nhập giá trị ngẫu nhiên cho mảng 2 chiều
            Random r = new Random();
            int dong = 3;
            int cot = 4;
            int[,] arr3 = new int[dong, cot];
            for(int i = 0; i < dong; i++){
                for(int j = 0; j < cot; j++){
                    // Console.Write(i);
                    // Console.Write(j + "\t");
                    arr3[i,j] = r.Next(1,101);
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr3[0,1]);
            Console.WriteLine(arr3[0,2]);
            Console.WriteLine(arr3[0,3]);


            // Xuất mảng bất kì
            // GetLength(0) get dòng của mảng
            // GetLength(1) get số cột
            for(int i = 0; i < arr3.GetLength(0); i++){
                for(int j = 0; j < arr3.GetLength(1); j++){
                    Console.Write(arr3[i,j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}