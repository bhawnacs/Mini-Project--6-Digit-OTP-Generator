using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project__6_Digit_OTP_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int otp = random.Next(100000, 999999);
            Console.WriteLine($" Your OTP is {otp}. Do not share it with anyone.");
        }
    }
}
