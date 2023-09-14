using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Calculator!");
                string user_input = "yes";
                while (user_input == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter first number");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter second number");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("These are available options, please choose one: \n+\n-\n*\n/");
                    string user_choose = Console.ReadLine();

                    switch (user_choose)
                    {
                        case "+":
                            int user_user = number1 + number2;
                            Console.WriteLine("Result is: " + user_user);
                            break;
                        case "-":
                            user_user = number1 - number2;
                            Console.WriteLine("Result is: " + user_user);
                            break;
                        case "*":
                            user_user = number1 * number2;
                            Console.WriteLine("Result is: " + user_user);
                            break;
                        case "/":
                            user_user = number1 * number2;
                            Console.WriteLine("Result is: " + user_user);
                            break;
                    }
                    Console.WriteLine("Do you want to start over?");
                    user_input = Console.ReadLine();
                }
            }
            catch 
            { 
                Console.WriteLine("Error, app wil close. Please press Enter."); 
            }

        }
    }
}
