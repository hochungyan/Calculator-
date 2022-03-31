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
                int[] Walls = new int[nOW];


                for (int A = 0; A < nOW; A++)
                {
                    Console.WriteLine("Input Your Length in meters For Wall " + (A + 1));
                    int L = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input Your Width in meters For Wall " + (A + 1));
                    int W = int.Parse(Console.ReadLine());
                    Walls[A] = L * W;
                    Console.WriteLine("Area for Wall " + (A + 1) + ": " + Walls[A]);
                    string colour;
                    float cOP;
                    Console.WriteLine("Select A colour");
                    colour = Console.ReadLine();
                    switch (colour.ToLower())
                    {
                        case "black":
                            cOP = 4;
                            Console.WriteLine("Black Colour Can Will Cost £4 each");

                            break;
                        case "red":
                            cOP = 5;
                            Console.WriteLine("Red Colour Can Will Cost £5 each");

                            break;

                        default:
                            cOP = 1;
                            Console.WriteLine("In");
                            break;






                    }

                    float R = (Walls[A] / cOP);
                    Console.WriteLine("Required Paint " + (A + 1) + ": " + R);



                }



                Console.ReadKey();
            }
        }

    }
}