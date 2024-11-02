using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_21
{
    public class StringExercise
    {
        public static void Main(string[] args)
        {
            // // Bài tập 19
            // // tính tổng các số trong chuỗi
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            int sum = 0;
            string[] list = str1.Split(" ");
            string strSo = "";
            foreach(string s in list){
                foreach(char c in s){
                    if(char.IsDigit(c)){
                        strSo += s + " ";
                        break;
                    }
                }
            }
            strSo = strSo.Trim();

            string[] list2 = strSo.Split(" ");

            foreach(string y in list2){
                sum += int.Parse(y);
            }
            Console.WriteLine($"Tổng các số trong chuỗi = {sum}");



            // // Bài tập 20
            Console.Write("Mời nhập mật khẩu(ít nhất 6 kí tự, 1 chữ cái, 1 chữ số): ");
            string passWord = Console.ReadLine();

            int demSo = 0; int demChu = 0;
            bool check = true;
            while(check){
                foreach(char c in passWord){
                    if(char.IsDigit(c)){
                        demSo++;
                    }
                    else if(char.IsLetter(c)){
                        demChu++;
                    }
                }
                if(demSo * demChu != 0 && passWord.Length >= 6){
                    Console.WriteLine("Đặt mật khẩu thành công!");
                    check = false;
                }
                else{
                    Console.Write("Nhập lại!(ít nhất 6 kí tự, 1 chữ cái, 1 chữ số): ");
                    passWord = Console.ReadLine();
                    check = true;
                }
            }
            Console.Write("Nhập lại mật khẩu: ");
            string passWordAgain = Console.ReadLine();
            int demSoLanNhap = 1;
            while(!passWord.Equals(passWordAgain)){
                if(demSoLanNhap >= 5){
                    Console.WriteLine("Khóa login");
                    break;
                }else{
                    demSoLanNhap++;
                    Console.Write($"Nhập sai, mời nhập lại lần thứ {demSoLanNhap}: ");
                    passWordAgain = Console.ReadLine();
                }
            }

                if(passWord.Equals(passWordAgain)){
                    Console.WriteLine("Success");
                }


            // // Bài 21
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            string result = "";

            Console.Write("Mời nhập vào tin nhắn cần mã hóa: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                char ch = char.ToLower(message[i]);

                if (a.Contains(ch)) // Kiểm tra xem ký tự có nằm trong chuỗi a không
                {
                    int index = a.IndexOf(ch);
                    result += b[index];
                }
                else
                {
                    result += message[i];
                }
            }

            Console.WriteLine("Tin nhắn sau khi mã hóa: " + result);


            // Bài 22
            Đếm từ tôi
            string toi = @"tôi yêu em tôi chịu khó tôi đẹp trai";
            string[] words = toi.Split(' ');
            int countTuToi = 0;
            foreach(string y in words){
                if("tôi".Equals(y)){
                    countTuToi++;
                }
            }
            Console.WriteLine($"Có {countTuToi} từ tôi");

            // Bài 23
            // Tách chuỗi và số
            Console.Write("Nhập vào chuỗi: ");
            string str2 = Console.ReadLine();
            string resultLetter = "";
            string resultDigit = "";
            for(int i = 0; i < str2.Length; i++){
                char c = str2[i];
                if(char.IsLetter(c)){
                    resultLetter += c;
                }
                else if(char.IsDigit(c)){
                    resultDigit += c;
                }
            }
            Console.WriteLine("Chữ: " + resultLetter);
            Console.WriteLine("Số: " + resultDigit);


        }
    }
}