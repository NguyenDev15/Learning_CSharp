using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_14
{
    public class ForEachAndContinueBreak
    {
        public static void Main(string[] args)
        {
            // ForEach
            int[] arr = {1,3,5,7,8,10,12}; // Array
            foreach(int i in arr){
                Console.Write("Nhập vào tháng: ");
                int month = int.Parse(Console.ReadLine());

                if(month == i){
                    Console.WriteLine($"Tháng {month} có 31 ngày");
                    break;
                }
                else if(month == 2){
                    Console.WriteLine($"Tháng {month} có 28 hoặc 29 ngày tùy vào năm");
                    break;
                }
                else{
                    Console.WriteLine($"Tháng {month} có 30 ngày");
                    break;
                }
            }


            // Continue và Break;
            // Continue sẽ bỏ qua không thực thi mà điều kiện đưa vào
            // Break sẽ dùng để thoát khỏi chương trình và vòng lặp khi thõa mản điều kiện
            int[] list = {1,3,5,7,8,10,12};
            foreach(int ii in list){
                if(ii == 3){
                    continue; // bỏ qua số 3
                }
                if(ii == 10){
                    break; // đến 10 thì thoát
                }
                Console.WriteLine("ii = " + ii);
            }
        }
    }
}