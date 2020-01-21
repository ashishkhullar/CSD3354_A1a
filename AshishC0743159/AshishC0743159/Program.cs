using System;

namespace AshishC0743159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State your Number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            Multiply m = new Multiply(userInput);
        }
    }

        class Multiply
        {
            public Multiply(double userInput)
            {
                Console.WriteLine("You are now in the Zero Argument Constructors!");
            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine("{0} times {1} = {2}", userInput, i , userInput*i);
            }


            }
        }
    }




