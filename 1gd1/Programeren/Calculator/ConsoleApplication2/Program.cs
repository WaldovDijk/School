using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
        class Program
        {
            static void Main(string[] args)
            {
                int Weeks = 52;
                Console.WriteLine("Hello User\n");

                Console.WriteLine("Please Enter Your Name:");
                string userName = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("Please Enter Your Age:");
                int userAge;
                userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Hello, {0} You're {2} years old and the current time is {1}\n", userName, System.DateTime.Now.TimeOfDay, userAge);

                int Answer = Weeks * userAge;
                Console.WriteLine("Weeks in 1 year ({0}) x Your age ({1}) = {2}", Weeks, userAge, Answer);
                Console.WriteLine("\n");

                int i = 0;
                while (i < 3)
                {
                    int num1;
                    int num2;
                    string operand;
                    float output;

                    Console.WriteLine("What do you wanna multiply?\n");

                    Console.WriteLine("Please Enter First Number:");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please Choose Operand (+, x, -, /):");
                    operand = Console.ReadLine();

                    Console.WriteLine("Please Enter Second Number:");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    switch (operand)
                    {
                        case "+":
                            output = num1 + num2;
                            break;
                        case "x":
                            output = num1 * num2;
                            break;
                        case "-":
                            output = num1 - num2;
                            break;
                        case "/":
                            output = num1 / num2;
                            break;
                        default:
                            output = 0;
                            break;
                    }

                    Console.WriteLine("Your Answer Is:\n" + num1.ToString() + " " + operand + " " + num2.ToString() + " = " + output.ToString());
                    Console.WriteLine("\n");

                    i++;

                }

                Console.WriteLine("Enter Any Key To Quit...");
                Console.ReadKey();

            }
            static void Secondary(string[] args)
            {


            }
        }
    }

