using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Total Number of walls
                Console.WriteLine("Input the Number of Walls ");
                int nOW = Int32.Parse(Console.ReadLine());
                float[] Walls = new float[nOW];
                //abcde

                int lit2 = 0;
                float R = 0;
                float lit1 = 0;
                for (int A = 0; A < nOW; A++)
                {
                    Console.WriteLine("Input Your Length in meters For Wall " + (A + 1));
                    int L = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input Your Width in meters For Wall " + (A + 1));
                    int W = int.Parse(Console.ReadLine());
                    Walls[A] = L * W;
                    Console.WriteLine("Area for Wall " + (A + 1) + ": " + Walls[A]);
                    Console.WriteLine("Colour You Can choose From");

                    string[] C = { "Black", "Red", "Green", "Blue" };
                    foreach (string c2 in C)
                    {

                        Console.WriteLine(c2.ToUpper());
                    };



                    string colour;
                    double cOP;
                    Console.WriteLine("Select A colour");
                    colour = Console.ReadLine();
                    switch (colour.ToLower())
                    {
                        case "black":
                            cOP = 24;
                            Console.WriteLine("2.5L Can Will Cost £24 each and 5L Can will Cost 48 each");
                            Console.WriteLine("which Lit can do you want");
                            lit1 = float.Parse(Console.ReadLine());

                            if (lit1 == 2.5)
                            {
                                lit2 = 24;
                                R = (Walls[A] / 35);
                            }

                            else if (lit1 == 5)
                            {
                                lit2 = 48;
                                R = (Walls[A] / 70);
                            }
                            else
                            { Console.WriteLine("Invalid"); }

                            break;

                        case "red":
                            cOP = 25;
                            Console.WriteLine("2.5L Can will Cost you £25 and 5L will cost you 49 each");
                            Console.WriteLine("which Lit can do you want");
                            lit1 = float.Parse(Console.ReadLine());
                            if (lit1 == 2.5)
                            {
                                lit2 = 25;
                                R = (Walls[A] / 35);
                            }
                            else if (lit1 == 5)
                            {
                                lit2 = 49;
                                R = (Walls[A] / 70);
                            }
                            else
                            { Console.WriteLine("Invalid"); }

                            break;


                        case "green":
                            cOP = 26;
                            Console.WriteLine("2.5L Green Colour Can Will Cost £26 each and 5L will cost you 52 each");
                            Console.WriteLine("which Lit can do you want");
                            lit1 = float.Parse(Console.ReadLine());
                            if (lit1 == 2.5)
                            {
                                lit2 = 26;
                                R = (Walls[A] / 35);
                            }
                            else if (lit1 == 5)
                            {
                                lit2 = 52;
                                R = (Walls[A] / 70);
                            }
                            else
                            { Console.WriteLine("Invalid"); }
                            break;

                        case "blue":
                            cOP = 28;
                            Console.WriteLine("2.5L Blue Colour Can Will Cost £28 each and 5L will cost you 55 each");
                            Console.WriteLine("which Lit can do you want");
                            lit1 = float.Parse(Console.ReadLine());
                            if (lit1 == 2.5)
                            {
                                lit2 = 28;
                                R = (Walls[A] / 35);
                            }
                            else if (lit1 == 5)
                            {
                                lit2 = 55;
                                R = (Walls[A] / 70);
                            }
                            else
                            { Console.WriteLine("Invalid"); }
                            break;



                        default:
                            cOP = 0;
                            Console.WriteLine("Invalid");
                            break;

                    }
                    //2.5L covers 35m^2, 5L covers 70m^2


                    double R2 = Math.Round(R);
                    double cost = R2 * cOP;
                    double cost2 = R2 * lit2;
                    Console.WriteLine("The coverage for 2.5 and 5 Lit Can is 35m^2 and 70m^2");
                    Console.WriteLine("Required Paint For Wall " + (A + 1) + ": " + R + " Units of " + lit1 + " Litre Can");
                    Console.WriteLine("Total Required Paint For Wall " + (A + 1) + ": " + Math.Round(R) + " Units of " + lit1 + " Litre Can");
                    Console.WriteLine("Cost : " + "£" + cost2);


                    Console.WriteLine("Thanks for using our service, would you like to provide us feedback?");
                    string yes;
                    string yes2;
                    yes = Console.ReadLine();
                    yes.ToLower();
                    while (yes == "yes")
                    {
                        Console.WriteLine("Please Email your feedback to feedback@paintnation.co.uk");
                        Console.WriteLine("Do you need further assistance");
                        yes2 = Console.ReadLine();
                        yes = yes2.ToLower();

                        if (yes == "yes")
                        {
                            Console.WriteLine("Please call 0112345678");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thank you for using our service!");
                        }

                    }
                }




            }



            Console.ReadKey();
        }
    }

}