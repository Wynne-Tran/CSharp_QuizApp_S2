using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Input;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, attemp = 0, count = 0,
                  percent1 = 0, percent2 = 0, percent3 = 0, percent4 = 0, percent5 = 0;
            WriteLine("Please enter your name to begin the quiz!");
            WriteLine("First name: ");
            string fName = ReadLine();
            WriteLine("Last name: ");
            string lName = ReadLine();
            if (fName != "" && lName != "")
            {

                WriteLine("This is a funny quiz about the animal!");
                WriteLine("Are you ready? (Y/N)");
                string userInput = ReadLine();
                do
                {
                    if (userInput == "Y" || userInput == "y")
                    {
                        attemp++;
                        WriteLine("Question 1: Which one is mammals?");
                        WriteLine("1: Snake");
                        WriteLine("2: Turtle");
                        WriteLine("3: Owl");
                        WriteLine("4: Monkey");
                        WriteLine("Your answer (choice a number form 1 to 4): ");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number == 4)
                        {
                            WriteLine("Congratulation! The answer is: Monkey");
                            percent1 = 20;
                        }
                        else
                        {
                            WriteLine("Please try again!");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number == 4)
                            {
                                WriteLine("Congratulation! The answer is: Monkey");
                                percent1 = 10;
                            }
                            else
                            {

                                WriteLine("Please try again!");

                                number = Convert.ToInt32(Console.ReadLine());

                                if (number == 4)
                                {
                                    WriteLine("Congratulation! The answer is: Monkey");
                                    percent1 = 5;
                                }
                                else
                                {
                                    WriteLine(" The answer is: Monkey");
                                    percent1 = 0;
                                }
                            }
                        }
                        WriteLine("Question 2: What was ancestor of human?");
                        WriteLine("1: Dinosaur");
                        WriteLine("2: Bear");
                        WriteLine("3: Monkey");
                        WriteLine("4: Sea Otto");
                        WriteLine("Your answer (choice a number form 1 to 4): ");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number == 3)
                        {
                            WriteLine("Congratulation! The answer is: Monkey");
                            percent2 = 20;
                        }
                        else
                        {
                            WriteLine("Please try again!");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number == 3)
                            {
                                WriteLine("Congratulation! The answer is: Monkey");
                                percent2 = 10;
                            }
                            else
                            {
                                WriteLine("Please try again!");
                                number = Convert.ToInt32(Console.ReadLine());
                                if (number == 3)
                                {
                                    WriteLine("Congratulation! The answer is: Monkey");
                                    percent2 = 5;
                                }
                                else
                                {
                                    WriteLine(" The answer is: Monkey");
                                    percent2 = 0;
                                }
                            }
                        }
                        WriteLine("Question 3: Where is hometown of Panda bear?");
                        WriteLine("1: China");
                        WriteLine("2: Vietnam");
                        WriteLine("3: Canada");
                        WriteLine("4: Yemen");
                        WriteLine("Your answer (choice a number form 1 to 4): ");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number == 1)
                        {
                            WriteLine("Congratulation! The answer is: China");
                            percent3 = 20;
                        }
                        else
                        {
                            WriteLine("Please try again!");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number == 1)
                            {
                                WriteLine("Congratulation! The answer is: China");
                                percent3 = 10;
                            }
                            else
                            {
                                WriteLine("Please try again!");
                                number = Convert.ToInt32(Console.ReadLine());
                                if (number == 1)
                                {
                                    WriteLine("Congratulation! The answer is: China");
                                    percent3 = 5;
                                }
                                else
                                {
                                    WriteLine(" The answer is: China");
                                    percent3 = 0;
                                }
                            }
                        }
                        WriteLine("Question 4: Which animal live the longest on earth?");
                        WriteLine("1: Human");
                        WriteLine("2: Greenland Shark");
                        WriteLine("3: Lamellibrachia Tube Worms");
                        WriteLine("4: Tuatara");
                        WriteLine("Your answer (choice a number form 1 to 4): ");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number == 2)
                        {
                            WriteLine("Congratulation! The answer is: Greenland Shark");
                            percent4 = 20;
                        }
                        else
                        {
                            WriteLine("Please try again!");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number == 2)
                            {
                                WriteLine("Congratulation! The answer is: Greenland Shark");
                                percent4 = 10;
                            }
                            else
                            {
                                WriteLine("Please try again!");
                                number = Convert.ToInt32(Console.ReadLine());
                                if (number == 2)
                                {
                                    WriteLine("Congratulation! The answer is: Greenland Shark");
                                    percent4 = 5;
                                }
                                else
                                {
                                    WriteLine(" The answer is: Greenland Shark");
                                    percent4 = 0;
                                }
                            }
                        }
                        WriteLine("Question 5: The world's most omnivorous animal?");
                        WriteLine("1: Human");
                        WriteLine("2: Pig");
                        WriteLine("3: Bear");
                        WriteLine("4: Dog");
                        WriteLine("Your answer (choice a number form 1 to 4): ");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number == 2)
                        {
                            WriteLine("Congratulation! The answer is: Pig");
                            percent5 = 20;
                        }
                        else
                        {
                            WriteLine("Please try again!");
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number == 2)
                            {
                                WriteLine("Congratulation! The answer is: Pig");
                                percent5 = 10;
                            }
                            else
                            {
                                WriteLine("Please try again!");
                                number = Convert.ToInt32(Console.ReadLine());
                                if (number == 2)
                                {
                                    WriteLine("Congratulation! The answer is: Pig");
                                    percent5 = 5;
                                }
                                else
                                {
                                    WriteLine(" The answer is: Pig");
                                    percent5 = 0;
                                }
                            }
                        }
                        count = percent1 + percent2 + percent3 + percent4 + percent5;
                        WriteLine("Your mark: " + count);

                        WriteLine("Do you want to try again? (Y/N)");
                        userInput = ReadLine();
                        if (userInput == "n" || userInput == "N")
                        {
                            break;
                        }
                    }
                    else 
                    {
                        WriteLine("Do you want to try again? (Y/N)");
                        userInput = ReadLine();
                        if (userInput == "N" || userInput == "n")
                        {
                            break;
                        }
                    }


                }
                while (userInput == "Y" || userInput == "y");
                count = percent1 + percent2 + percent3 + percent4 + percent5;

                DateTime now = DateTime.Now;
                WriteLine(now);
                WriteLine("Your full name is: " + fName + " " + lName);
                WriteLine("Your mark at the last quiz is: " + count);
                WriteLine("Your total percent is: " + count + "/100 would be " + count + "%");
                WriteLine("You do this quiz " + attemp + " times !");

            }
            else
            {
                WriteLine("You have to enter your full name to do this quiz !");

            }
            ReadLine();
        }
    }
}
