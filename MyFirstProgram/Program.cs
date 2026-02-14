using System;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;


namespace MyFirstProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 21);

            Console.Write(" Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(" do you want  to try to guees a number bettwen 0-20 ," + name);
            Console.WriteLine("");





            string a1 = "yes", a2 = "no";
            Console.WriteLine(" answer the question with yes/no only!");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("do you ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("agree");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ?");
            Console.Write(" or ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" not ? ");
            Console.ForegroundColor = ConsoleColor.White;
            a1 = Console.ReadLine();
            Console.WriteLine(" Now it's time to guees ! insert a number : ");
            int guess = int.Parse(Console.ReadLine());

            if (a1 == "yes")//
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Ok! , here is the  instructions : ");
                Console.WriteLine("");
                Console.WriteLine(" you have to guees the number ( bettwen 0-20 ),try your best " + name);
                Console.WriteLine("");

                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Magenta;
               
                if (guess < 0 || guess > 20)
                {
                    Console.WriteLine(" invaild number :");
                    int @try = int.Parse(Console.ReadLine());
                    while (@try > 20 || @try < 0)
                    {

                        Console.WriteLine(" invaild number :");
                        @try = int.Parse(Console.ReadLine());

                        if (@try <= 20 && @try >= 0)
                        {

                            while (guess > randomNumber)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();
                                Console.WriteLine(" the number to choose is bigger then the righ one , but we don't know by how much :( ");
                                Console.WriteLine(" try agine : ");
                                guess = int.Parse(Console.ReadLine());
                                if (guess == randomNumber)
                                {
                                    Console.BackgroundColor = ConsoleColor.Green
                                        ;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine(" you wonnnnnn!!!, good job " + name);
                                }



                            }

                            while (guess < randomNumber)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();
                                Console.WriteLine(" the number to choose is smaller then the righ one , but we don't know by how much :( ");
                                Console.WriteLine(" try agine : ");
                                guess = int.Parse(Console.ReadLine());
                                if (guess == randomNumber)
                                {
                                    Console.BackgroundColor = ConsoleColor.Green
                                        ;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine(" you wonnnnnn!!!, good job " + name);
                                }



                            }




                        }
                    }

                }
                else
                {
                    while (guess > randomNumber)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine(" the number to choose is bigger then the righ one , but we don't know by how much :( ");
                        Console.WriteLine(" try agine : ");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == randomNumber)
                        {

                            Console.BackgroundColor = ConsoleColor.Green
                                        ;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(" you wonnnnnn!!!, good job " + name);
                        }



                    }

                    while (guess < randomNumber)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine(" the number to choose is smaller then the righ one , but we don't know by how much :( ");
                        Console.WriteLine(" try agine : ");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == randomNumber)
                        {
                            Console.BackgroundColor = ConsoleColor.Green
     ;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(" you wonnnnnn!!!, good job " + name);
                        }



                    }









                }


            }





            else if (a2 == "no")
            {

                Console.WriteLine(" i don't have the time for you , go back and say yes");


            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" you want to play another game ? yes or no");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine(" i'm tired go look in google for games to play");
            }
            else
            {
                Console.WriteLine(" thank you for being here " + name);

            }

        }





    }




}




