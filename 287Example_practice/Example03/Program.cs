using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
           // int nationalNo = Console.ReadLine();
            //int a = 1000;
            //string text = a.ToString();

            Console.WriteLine ("請輸入National No:");
            int nationalNo = -1;
            //int.TryParse(Console.ReadLine(), out nationalNo);
            try
            {
                nationalNo = int.Parse(Console.ReadLine());
            }
            catch


        }
    }
}
