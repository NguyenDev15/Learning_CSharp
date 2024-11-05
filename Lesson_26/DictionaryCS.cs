using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_26
{
    public class DictionaryCS
    {
        public static void Main(string[] args)
        {
            // khai báo dic
            Dictionary<int,string> dic1 = new Dictionary<int, string>();
            // khởi tạo và gán giá trị
            Dictionary<int,string> dic2 = new Dictionary<int, string>(){ {1, "Haha"}, {2, "Alo"} };

            // Methods
            
            // dic.Add() -> thêm phần tử vào cuối dic
            dic2.Add(4,"Dương Văn Tính"); 
            dic2.Add(5,"Lâm Cơ Hàn"); 
            dic2.Add(6,"Nguyễn Tiều Tụy"); 

            // Duyệt dic
            // KeyValuePair
            foreach(KeyValuePair<int,string> i in dic2){
                Console.WriteLine(i);
                Console.WriteLine($"Key: {i.Key}\nValue: {i.Value}");
            }

            // dic.ContainsKey -> ktra xem có tồn tại key không
            bool kq = dic2.ContainsKey(2); // Key 2 có tồn tại -> trả True
            Console.WriteLine(kq);

            // dic.ContainsValue -> ktra xem có tồn tai value không
            bool kq2 = dic2.ContainsValue("Haha"); // Value Haha có tồn tại -> trả True
            Console.WriteLine(kq2);

            // dic[key] -> get value từ key
            string name = dic2[1];
            Console.WriteLine("dic[1] = " + name);

            // dic.Remove(key) -> xóa phần tử theo key
            dic2.Remove(1);
            Console.WriteLine("dic sau xóa tại 1: ");
            foreach(KeyValuePair<int,string> i in dic2){
                Console.WriteLine(i);
            }

            // dic.Clear() xóa toàn bộ
            dic2.Clear();
            Console.WriteLine("dic2.Count = " + dic2.Count());

            // dic.Keys.ToList() và dic.Values.ToList()
            // Chuyển Key về 1 List và Chuyển Value về 1 List riêng tách biệt
            Dictionary<int,string> dic3 = new Dictionary<int, string>(){ {1, "Haha"}, {2, "Alo"}, {3, "Bye"} };
            List<int> ds1 = new List<int>();
            ds1 = dic3.Keys.ToList();
            Console.WriteLine("Chuyển Keys thành List: ");
            foreach(int i in ds1){
                Console.Write(i + " ");
            } 

            Console.WriteLine("");

            Console.WriteLine("Chuyển Values thàn List: ");
            List<string> ds2 = new List<string>();
            ds2 = dic3.Values.ToList();
            foreach(string i in ds2){
                Console.Write(i + " ");
            }

            // dic.Count() đếm số phần tử trong dic
        }
    }
}