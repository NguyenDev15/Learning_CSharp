using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_27
{
    public class DictinaryExercise
    {
        public static void Main(string[] args)
        {
            // Bài tập 29
            // Viết chương trình kiểm tra user và pass trong dictionary
            // Dictionary<string,string> dic = new Dictionary<string, string>()
            // { {"Abc123", "123123"}, {"Xyz098", "123123"}, {"Asd456", "123123"} };
            // int count = 0;
            // Console.WriteLine("---Login---");
            // Console.Write("Username: ");
            // string userName = Console.ReadLine();
            // Console.Write("Password: ");
            // string passWord = Console.ReadLine();
            
            // if (!dic.ContainsKey(userName))
            // {
            //     Console.WriteLine("User Không tồn tại");
            // }
            // else
            // {
            //     if(dic[userName] == passWord){
            //         Console.WriteLine("Đăng nhập thành công");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Mật khẩu sai");
            //     }
            // }
           

           // Bài tập 30
           /*
            Dictionary<string, int> dic2 = new Dictionary<string, int>()
            { {"A",1},{"B",2},{ "C",3},{ "D",2},{ "E",1},{ "F",4},{ "G",2},{ "H",4},{ "I",1},
            { "J",8},{ "K",5},{ "L",1},{ "M",3},{ "N",1},{ "O",1},{ "P",3},{ "Q",10},{ "R",1},
            { "S",1},{ "T",1},{ "U",1},{ "V",4},{ "W",4},{ "X",8},{ "Y",4},{ "Z",10} };
            1: Tách số và chữ , hiển thị lên màn hình	
            2: tính tổng các số
            3: chuyển đổi chuỗi : "University of Technology and Education" sang số
           */
            Dictionary<string, int> dic2 = new Dictionary<string, int>()
            { {"A",1},{"B",2},{ "C",3},{ "D",2},{ "E",1},{ "F",4},{ "G",2},{ "H",4},{ "I",1},{ "J",8},{ "K",5},{ "L",1},{ "M",3},{ "N",1},{ "O",1},{ "P",3},{ "Q",10},{ "R",1},{ "S",1},{ "T",1},{ "U",1},{ "V",4},{ "W",4},{ "X",8},{ "Y",4},{ "Z",10} };

            List<string> dsString = new List<string>();
            List<int> dsInt = new List<int>();
            dsString = dic2.Keys.ToList();
            dsInt = dic2.Values.ToList();
            foreach(string i in dsString){
                Console.Write(i + " ");
            } 
            Console.WriteLine("");
            foreach(int i in dsInt){
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            int sum = 0;
            // tính tổng
             foreach(int i in dsInt){
                sum += i;
            }
            Console.WriteLine("Tổng các số = " + sum);

            // chuyển từ chữ thành số
            string s = "University of Technology and Education";
            string s2 = "";
            foreach(char c in s){
                s2 += char.ToUpper(c);
            }
            string strSo = "";
            foreach(char c in s2){
                if(c == ' '){
                    strSo += c;
                }else{
                    strSo += dic2[c.ToString()];
                }
                Console.WriteLine(c);
           
            }
            Console.WriteLine(s2);
            Console.WriteLine(strSo);
        
        
        }
    }
}