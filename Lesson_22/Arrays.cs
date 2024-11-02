using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_22
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            // khai báo mảmg
            char[] c;
            string[] str;
            int[] so;

            // khởi tạo mảng ban đầu
            int[] stt = new int[5];

            // khởi tạo mảng và gán luôn giá trị
            int[] stt2 = new int[5] {1,2,3,4,5};

            // Khởi tạo mảng ngãu nhiên
            Random r = new Random();
            int[] stt3 = new int[2] {r.Next(1,101), r.Next(1,101)};
            foreach(int i in stt3){
                Console.Write(i + " ");
            }

            // Truy xuất phần tử qua index
            int[] array1 = {1,2,4,5};
            Console.WriteLine("\n"+array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[3]);
            Console.WriteLine(array1[array1.Length - 1]); // index đi từ 0, Length đi từ 1 

            // CopyTo (copy đè giá trị mảng đã có)
            int[] array2 = {1,5,3,7,4};
            int[] array3 = {7,2,9,1,5,6,7};
            array2.CopyTo(array3, 2);
            foreach(int i in array3){
                Console.WriteLine(i);
            }

            // Clone() tạo ra mảng mới trên vùng nhớ mới không ảnh hưởng cái cũ
            int[] array4 = {1,5,7,4,6,78};
            int[] array5 =  (int[])array4.Clone();
            foreach(int i in array5){
                Console.WriteLine(i);
            }

            // Array.Reverse() Đảo ngược mảng
            int[] array6 = {1,5,7,4,6,78};
            Array.Reverse(array6);
            foreach(int i in array6){
                Console.WriteLine(i);
            }

            // Array.Sort() sắp xếp mảng tăng dần
            int[] array7 = {1,5,7,4,6,78};
            Array.Sort(array6);
            foreach(int i in array6){
                Console.Write(i);
            }


            // Tìm kím mảng(tìm BinarySearch chỉ áp dụng khi đã Sort) trả về index, không thấy trả -1
            Console.Write("\nMời nhập vào số cần tìm: ");
            int nhapSo = int.Parse(Console.ReadLine());
            int[] array8 = {1,6,3,12,54,35,75,12,45,75,2};
            Array.Sort(array8);
            int kq = Array.BinarySearch(array8, nhapSo);
            if(kq == -1){
                Console.WriteLine("Không tìm thấy");
            }else{
                Console.WriteLine($"Tìm thấy số {nhapSo} ở index {kq}");
            }


        
        }
    }
}