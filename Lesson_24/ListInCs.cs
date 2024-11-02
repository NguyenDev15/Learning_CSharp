using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_24
{
    public class ListInCs
    {
        public static void Main(string[] args)
        {
            // Do hạn chế của mảng
            // Nên List sẽ có thể thêm, xóa, thay đổi size

            // 1. Khởi tạo 1 List
            List<string> ds1 = new List<string>(); // ds các phần tử là string
            List<int> ds2 = new List<int>(); // ds các phần tử là 

            // 2. Khởi tạo danh sách có sẵn phần tử, liệt kê ở {}
            List<int> ds3 = new List<int>{1,2,5,6,7,3,65,1};
            foreach(int i in ds3){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.Add() thêm phần tử vào cuối
            List<int> ds4 = new List<int>{1,2,4,5};
            ds4.Add(100);
            ds4.Add(200);
            ds4.Add(300);
            foreach(int i in ds4){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.Remove() xóa phần tử đầu tiên nếu tìm thấy trong list
            List<int> ds5 = new List<int>{5,3,5,7,1};
            ds5.Remove(5); // xóa số 5 đầu tiên gặp được
            foreach(int i in ds5){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.Count() đếm số phần tử trong list => giống Length trong array
            List<int> ds6 = new List<int>{5,3,5,7,1};
            Console.WriteLine(ds6.Count());

            Console.WriteLine();
            // list.Clear() xóa toàn bộ phần tử
            List<int> ds7 = new List<int>{5,3,5,7,1};
            ds7.Clear();

            Console.WriteLine();
            // list.AddRange thêm toàn bộ 1 danh sách này vào cuối danh sách kia
            List<int> ds8 = new List<int>{5,3,5,7,1};
            List<int> ds9 = new List<int>{100,200};
            ds8.AddRange(ds9); // thêm ds9 vào cuối ds8 
            foreach(int i in ds8){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.Contains() kiểm tra xem có phần tử con không
            List<int> ds10 = new List<int>(){5,3,5,7,1};
            bool check = ds10.Contains(5);
            Console.WriteLine(check);

            Console.WriteLine();
            // list.GetRange(begin index, end index) Trả về 1 list con, đếm kí tự của list nguồn
            List<int> ds11 = new List<int>(){5,3,5,7,1};
            List<int> ds12 = ds11.GetRange(1, 3);
            foreach(int i in ds12){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.IndexOf(value) truyền giá trị và sẽ trả về index tìm thấy đầu tiên, ngược lại -1
            List<int> ds13 = new List<int>(){5,3,5,7,1};
            int checkIndex = ds13.IndexOf(5);
            Console.WriteLine("Vị trí index: " + checkIndex);

            Console.WriteLine();
            // list.Insert(index, value) chèn giá trị theo index chỉ định
            List<int> ds14 = new List<int>(){5,3,5,7,1};
            ds14.Insert(0, 1000);
            foreach(int i in ds14){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.InsertRange(index, valueList) chèn thêm vị trí ở index gốc
            List<int> ds15 = new List<int>(){5,3,5,7,1};
            List<int> ds16 = new List<int>(){7,1};
            ds15.InsertRange(2, ds16); // chèn ds16 vào ds15 ở index 2 của ds15 và đẩy các index khác về sau
            foreach(int i in ds15){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.RemoveAt()(int index) xóa phần tử chỉ định tại index
            List<int> ds17 = new List<int>(){5,3,5,7,1};
            ds17.RemoveAt(0);
            foreach(int i in ds17){
                Console.Write(i + " ");
            }
            
            Console.WriteLine();
            // list.RemoveRange(begin index, count) xóa từ vị trí index cho đến bao nhiêu phần tử
            List<int> ds18 = new List<int>(){5,3,5,7,1};
            ds18.RemoveRange(0,2); // xóa từ index 0 xoá đi 2 phần tử
            foreach(int i in ds18){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.Reverse() Đảo ngược list
            List<int> ds19 = new List<int>(){5,3,5,7,1};
            ds19.Reverse();
            foreach(int i in ds19){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.Sort() Sắp xếp tăng dẩn
            List<int> ds20 = new List<int>(){5,3,5,7,1};
            ds20.Sort();
            foreach(int i in ds20){
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // list.BinarySearch() tìm kím nhị phân -> chỉ dùng sau khi đã Sort -> tìm xong sẽ trả về index
            // Không thấy trả - 1
            int kq = ds20.BinarySearch(1);
            Console.WriteLine(kq);

            Console.WriteLine();
            // list.Max , list.Min
            int kq2 = ds20.Max();
            int kq3 = ds20.Min();
            Console.WriteLine("Max ds20 = " + kq2);
            Console.WriteLine("Min ds20 = " + kq3);


        }
    }
}