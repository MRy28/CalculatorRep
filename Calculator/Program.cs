using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first num:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter -, +, * or /:");
            string menu = Convert.ToString32(Console.ReadLine());
            Console.WriteLine("Enter your second num:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if(menu == "-")
            Console.WriteLine("The result is: " + num-num1);
                        else if(menu == "+")
            Console.WriteLine("The result is: " + num+num1);
                        else if(menu == "*")
            Console.WriteLine("The result is: " + num*num1);
                        else(menu == "/")
            Console.WriteLine("The result is: " + num/num1);

             Console.WriteLine("Press any key to exit.");
             
            Console.ReadKey();
        }
    }
}

