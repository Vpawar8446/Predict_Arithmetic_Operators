using System;

namespace Predict_Arithmetic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int num1=10,num2=3,num3=27,num4=97,num5=97;

            num1 %= 3;
            Console.WriteLine("Modulus(Remainder) Ooperator : " + num1); // num1 = num1(10) % 3

            num2 *= 2;
            Console.WriteLine("Multiplication Ooperator : " + num2); //num2 = num2(3) * 2

            num3 /= 3;
            Console.WriteLine("Division(Quotient) Ooperator : " + num3); //num3 = num3(10) / 3

            num4 -= 89;
            Console.WriteLine("Substraction Ooperator : " + num4); //num4 = num4(97) - 3

            num5 -= 107;
            Console.WriteLine("Substraction Ooperator : " + num5); //num5 = num5(10) - 3


        }
    }
}
