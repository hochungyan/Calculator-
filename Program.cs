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
                        
                        Console.WriteLine(c2.ToUpper() );
                            };
                 


                    string colour;
                    double cOP;
                    Console.WriteLine("Select A colour");
                    colour = Console.ReadLine();
                    switch (colour.ToLower())
                    {
                        case "black":
                            cOP = 24;
                            Console.WriteLine("Black Colour Can Will Cost £24 each");

                            break;

                        case "red":
                            cOP = 25;
                            Console.WriteLine("Red Colour Can Will Cost £25 each");

                            break;


                        case "green":
                            cOP = 26;
                            Console.WriteLine("Green Colour Can Will Cost £26 each");

                            break;

                        case "blue":
                            cOP = 28;
                            Console.WriteLine("Blue Colour Can Will Cost £28 each");

                            break;



                        default:
                            cOP = 0;
                            Console.WriteLine("Invalid");
                            break;

                    }

                    float R = (Walls[A]/ 35);
                    double R2 = Math.Round(R);
                    double cost = R2 * cOP;
                    Console.WriteLine("The coverage for 2.5 Lit Can is 35m^2");
                    Console.WriteLine("Required Paint For Wall " + (A + 1) + ": " + R +" Units of 2.5 Litre Can");
                    Console.WriteLine("Total Required Paint For Wall "  +(A +1) + ": "+ Math.Round(R) + " Units of 2.5 Litre Can");
                    Console.WriteLine("Cost : " + "£" + cost);

                }



                Console.ReadKey();
            }
        }

    }
}