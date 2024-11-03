using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_25
{
    public class ListExercise
    {
        public static void Main(string[] args)
        {   
            // Bài tập 24
            // Viết chương trình tạo ra 1 list có n phần tử, 
            // Các phần tử là số ngẫu nhiên(1,101)
            Random r = new Random();
            Console.Write("Mời nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ds1 = new List<int>();
            for(int i = 0; i < n; i++){
                ds1.Add(r.Next(1,101));
            }
            foreach(int i in ds1){
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // Bài tập 25
            // Viết chương trình nhập vào 1 danh sách list
            // 1. Tạo ra list mới rồi mũ 2 lên
            // 2. Xác định bao nhiêu phần tử > 50
            Console.Write("Mời nhập số lượng phần tử: ");
            int n2 = int.Parse(Console.ReadLine());
            List<int> ds2 = new List<int>();
            for(int i = 0; i < n2; i++){
                Console.Write($"ds2[{i}] = ");
                ds2.Add(int.Parse(Console.ReadLine()));
            }
            foreach(int i in ds2){
                Console.Write(i + " ");
            }
            
            // Bình phương
            List<double> ds3 = new List<double>();
            foreach(int i in ds2){
                ds3.Add(Math.Pow(i,2));
            }
            Console.WriteLine("\nDs3: ");
            foreach(int i in ds3){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // Đếm pt > 50
            int countHon50 = 0;
            int countNho50 = 0;
            foreach(int i in ds3){
                if(i > 50){
                    countHon50++;
                }else{
                    if(i < 51){
                        countNho50++;
                    }
                }
            }
            Console.WriteLine($"Có {countHon50} phần tử > 50");
            Console.WriteLine($"Có {countNho50} phần tử < 50");


            // Bài tập 26
            // Viết chương trình trả lời các kết quả phép tính
            // {"2 + 5 + 7 =", "5 * 10 =", "sqrt(16) =", "12%2 =", "5//2="}
            List<string> quest = new List<string>(){"2 + 5 + 7 = ", "5 * 10 = ", "sqrt(16) = ", "12%2 = ", "5//2 = "};
            List<int> traLoi = new List<int>(){14, 50, 4, 0, 4};
            for(int i = 0; i < quest.Count; i++){
                Console.Write(quest[i]);

                int answer = int.Parse(Console.ReadLine());
                if(answer == traLoi[i]){
                    Console.WriteLine("Success");
                }else{
                    Console.WriteLine($"Fail, câu trả lời là: {traLoi[i]}");
                }
            }


    







        }
        
    }
}