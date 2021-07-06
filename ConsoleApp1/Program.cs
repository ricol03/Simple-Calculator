using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main()
        {
            string answer = "y";
            //gives an initial *yes* value to answer, because, if you opened the program, you most likely want to do a calculation
            string answer2 = " ";
            string yes = "y";
            string no = "n";

            // ^
            // |
            // *yes* and *no* represent values that'll be used on the while loop

            Console.WriteLine("Simple Calculator | by ricol03 | Version 1.1.5");
            Console.WriteLine(" ");

            // some info about the program (name | author | version)

            while (answer == yes && answer != no)

            {
                try
                {
                    
                    Console.Write("Enter a number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // the user enters a number which will then be transformed into a double

                    Console.WriteLine(" ");

                    Console.Write("Enter an operator (+, -, *, /, pow or sqrt): ");
                    string op = Console.ReadLine();

                    //the users enters an operator, it will be saved as a string

                    Console.WriteLine(" ");

                    if (op != "sqrt") //if the operator is different from square root, it does the following
                    {
                        Console.Write("Enter a number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        if (op == "+")
                        {
                            Console.WriteLine("Result: " + (num1 + num2));
                        }

                        else if (op == "-")
                        {
                            Console.WriteLine("Result: " + (num1 - num2));
                        }

                        else if (op == "*")
                        {
                            Console.WriteLine("Result: " + (num1 * num2));
                        }

                        else if (op == "/")
                        {
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            Console.WriteLine("Result: " + (num1 / num2));
                        }

                        else if (op == "pow")
                        {
                            Console.WriteLine("Result: " + (Math.Pow(num1, num2)));
                        }

                        else
                        {
                            Console.Write("ERROR! ");
                        }
                    }

                    Console.WriteLine(" ");

                    if (op == "sqrt")
                    {
                        Console.WriteLine("Result: " + (Math.Sqrt(num1)));
                    }

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " " + "Press ENTER to continue.");
                    Console.ReadLine();
                }

                Console.Write("Do you want to make another calculation? (y/n) ");
                answer = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");

                if (answer == yes)
                {
                    continue;
                }

                else if (answer == no)
                {
                    break;
                    
                    /*Console.Write("Are you sure you want to exit? (y/n) ");
                    answer2 = Console.ReadLine();

                    if (answer2 == yes)
                    {
                        Console.WriteLine("Program was terminated. Press any key to close.");
                        Console.ReadLine();
                        break;
                    }

                    else if (answer2 == no)
                    {
                        

                    }

                    else
                    {
                        Console.WriteLine("No answer was given. Program has ended. Press ENTER to exit.");
                        Console.ReadLine();
                        break;

                    */ 
                }

                else
                {
                    Console.WriteLine("No answer was given. Program will terminate. Press ENTER to close.");
                    Console.ReadLine();
                }

            }
        }
    }
}
