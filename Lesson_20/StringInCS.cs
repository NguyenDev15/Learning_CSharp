using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_20
{
    public class StringInCS
    {
        public static void Main(string[] args)
        {
            // Chuỗi trong CS (string)

            // Khai báo chuỗi có đường dẫn dùng @"" nếu không phải dùng kiểu khác
            string str = @"D:\Program Files(x86)"; // @"";
            Console.WriteLine(str);
            string str2 = "Có người nói rằng: \"alo alo\" "; //    \" des \"
            Console.WriteLine(str2);

            // chuyển đổi sang chuỗi
            int i = 123;
            string str3 = i + "";
            Console.WriteLine(str3);
            Console.WriteLine("Kiểu dữ liệu của str3: " + str3.GetType().ToString());

            // tách chuỗi thành các kí tự lẻ
            string str4 = "Xinchao";
            char[] list = str4.ToCharArray();
            Console.WriteLine(list);
            Console.WriteLine(list.GetType().ToString());

            // Length thì đếm từ 1 còn index từ 0

            // vận dụng 
            // đếm số, space, in hoa, thường
            int upper = 0; int lower = 0;
            int space =0; int digit = 0;
            string str5 = "Alo Alo 123 co gi Khong";
            char[] list2 = str5.ToCharArray();
            
                foreach (char c in list2)
            {
                if (char.IsLower(c))
                {
                    lower++;
                }
                else if (char.IsUpper(c))
                {
                    upper++;
                }
                else if (char.IsDigit(c))
                {
                    digit++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    space++;
                }
            }
            
            Console.WriteLine("Số chữ thường: " + lower);
            Console.WriteLine("Số chữ hoa: " + upper);
            Console.WriteLine("Số chữ số: " + digit);
            Console.WriteLine("Số khoảng trắng: " + space);

            // so sánh chuỗi 
            string str6 = "abc1";
            string str7 = "abc1";
            Console.WriteLine(str6.CompareTo(str7)); // 2 chuỗi bằng nhau nên = 0

            // Kiểm tra chuỗi con
            string str8 = "abc";
            string str9 = "abcde";
            bool checkStr = str9.Contains(str8);
            Console.WriteLine(checkStr);

            // Hàm Copyto 
            string str10 = "123456";
            char[] list3 = new char[6]; // tạo mảng có dộ dài 6
            list3[0] = 'a';
            list3[1] = 'b';
            str10.CopyTo(1, list3, 2, 4);
            Console.WriteLine(list3);

            // kiểm tra xem có kết thúc bằng chuỗi con hay không 
            string str11 = "tuhocc.mp3";
            bool checkStr2 = str11.EndsWith(".mp3");
            Console.WriteLine(checkStr2);

            // kiểm tra xem có bắt đầu bằng chuỗi con hay không
            string str111 = "alo1234";
            Console.WriteLine(str111.StartsWith("alo"));

            // gán chuỗi theo string.Format
            int n =14;
            string str12 = string.Format($"n = {n} và căn bậc 2 của {n} = {Math.Sqrt(n)}");
            Console.WriteLine(str12);

            // Equals kiểm tra chuỗi
            string str13 = "a";
            string str14 = "a";
            Console.WriteLine(str13.Equals(str14));

            // Insert chèn chuỗi
            string str15 = "1";
            string str16 = "234";
            str15 = str15.Insert(1,str16); // chèn từ vị trí index 1 
            Console.WriteLine(str15);

            // IndexOf kiểm tra vị trí index
            string str17 = "123a"; 
            Console.WriteLine(str17.IndexOf("a"));
            Console.WriteLine(str17[str17.Length -1]); // Length = 4 mà -1 thì sẽ xuất tại vị trí index 3

            // LastIndexOf trả về vị trí index xuất hiện cuối
            string str18 = "ffdwdwq";
            Console.WriteLine(str18.LastIndexOf("a")); // trả về -1 vì không có a xuất hiện cuối cùng

            // Remove(index, count)
            string str19 = "ggq1123das";
            Console.WriteLine(str19.Remove(3, 4)); // xóa từ index 3 xóa đi 4 kí tự

            // Replace(old, new)
            string str20 = "123aasas";
            Console.WriteLine(str20.Replace("123","abc")); // thay thế "123" thành "abc"

            // Substring trích lọc chuỗi con từ chuỗi gốc
            string str21 = "abcdefgh";
            string str22 = str21.Substring(1,4); // lấy từ vị trí index 1, lấy 4 kí tự
            Console.WriteLine(str22);

            // ToLower() and ToUpper trả về chữ hoa và thường
            string str23 = "a";
            string str24 = "A";
            Console.WriteLine(str23.ToUpper());
            Console.WriteLine(str24.ToLower());

            // Trim() xóa toàn bộ khoảng trắng ở đầu và cuối
            string str25 = "    a     ";
            Console.WriteLine(str25.Trim());

            // TrimEnd() và TrimStart xóa toàn bộ space ở cuối và đầu
            string str26 = "        a             ";
            Console.WriteLine(str26.TrimStart());

            // split tách chuỗi trả về mảng
            string str27 = @"D:\Program Files(x86)\New ProJect\Alo";
            string[] list4 = str27.Split("\\");
            Console.WriteLine(list4[0]);
            Console.WriteLine(list4[1]);
            Console.WriteLine(list4[2]);
            Console.WriteLine(list4[3]);

            // join string nối phần tử của 1 list thành chuỗi
            string[] list5 = new string[3];
            list5[0] = "a";
            list5[1] = "b";
            list5[2] = "c";
            string str28 = string.Join("-", list5);
            Console.WriteLine(str28);
        }
    }
}