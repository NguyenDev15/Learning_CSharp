using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_18
{
    public class DateTimeInCSharp
    {
        public static void Main(string[] args)
        {
            // Date time trong C#
            DateTime birthday = new DateTime(2000,5,1); // (YYYY/mm/dd);
            Console.WriteLine("Ngày tháng năm sinh: " + birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngày sinh: " + birthday.ToString("dd"));
            Console.WriteLine("Tháng sinh: " + birthday.ToString("MM"));
            Console.WriteLine("Năm sinh: " + birthday.ToString("yyyy"));

            // Viết chương trình cho người dùng nhập tháng ngày năm
            Console.Write("Mời nhập vào tháng ngày năm: ");
            string s = Console.ReadLine();
            DateTime birthday2 = DateTime.Parse(s);
            Console.WriteLine("Ngày sinh: " + birthday2.ToString("dd"));
            Console.WriteLine("Tháng sinh: " + birthday2.ToString("MM"));
            Console.WriteLine("Năm sinh: " + birthday2.ToString("yyyy"));
        }
    }
}