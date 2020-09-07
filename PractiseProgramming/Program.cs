using System;

namespace PractiseProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number:");
            int num = Convert.ToInt32 (Console.ReadLine());


            
            if (num > 10)
            {
                Console.WriteLine("If statement result:Value is greater than 10");
                    
            }

            else 
            { 
                Console.WriteLine("If statement result:Value is not greater than 10");
            }
            

            switch (num)
            {
                case 1:num = num * 1; 
                       Console.WriteLine(num);
                     break;
                case 2:
                    num = num * 2;
                    Console.WriteLine(num);
                    break;
                case 3:
                    num = num * 3;
                    Console.WriteLine(num);
                    break;
                case 4:
                    num = num * 4;
                    Console.WriteLine(num);
                    break;
               default:
                    Console.WriteLine(num);
                        break;
            }

            String result1 = (num > 10) ? "Value is greater than 10" : "Value is not greater than 10";
            int result = (num > 10) ? 111 : 222;
            Console.WriteLine("Ternary Operator result:" + result);
        }
    }
}
