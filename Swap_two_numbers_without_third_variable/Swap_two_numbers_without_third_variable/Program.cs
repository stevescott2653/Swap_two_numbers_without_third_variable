using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_two_numbers_without_third_variable
{
    public class SwapExample
    {
        public static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a= "+a+" b= "+b);
            a = a * b; // a=50(5*10)
            b = a / b; // b=5(50/10)
            a = a / b; // a=10(50/5)
            Console.WriteLine("After swap a= "+a+" b= "+b);
        }
            
    }
}
