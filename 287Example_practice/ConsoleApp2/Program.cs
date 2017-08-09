using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入使用者姓名:");
            string UserName = Console.ReadLine();
            Console.WriteLine("你好 {0}先生", UserName);
            Console.Write ("請問你是第一次嗎:");
            String Answer = Console.ReadLine();
            Console.WriteLine("謝謝你的答案，{0}先生, {1}第一次",UserName, Answer);


            //數字轉文字
            float a = 0.587492f;
            string Price = a.ToString();
            Console.WriteLine("價格 {0}", Price);


            //文字轉數字
            Console.Write("請問今年幾歲:");
            string Age = Console.ReadLine();
            int Year = int.Parse(Age);
            Console.WriteLine("今年{0}歲", Year);

            Console.Write("學生證號碼:");
            int StudentNO = int.Parse (Console.ReadLine());
            Console.WriteLine("你的號碼是:{0}", StudentNO);

        }
    }
}
