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
            //Total Number of walls
            Console.WriteLine("Input the Number of Walls (MAX WALL IS 3)");
            int nOW = Int32.Parse(Console.ReadLine());


            if (nOW == 3)
            {

                //Wall 1
                Console.WriteLine("Input Your Length in meters For Wall 1");
                int Length = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input Your Width in meters For Wall 1");
                int Width = Convert.ToInt32(Console.ReadLine());
                int Area = (Length * Width);

                //Wall 2
                Console.WriteLine("Input Your Length in meters For Wall 2");
                int Length2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input Your Width in meters For Wall 2");
                int Width2 = Convert.ToInt32(Console.ReadLine());
                int Area2 = (Length2 * Width2);

                //Wall 2
                Console.WriteLine("Input Your Length in meters For Wall 3");
                int Length3 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input Your Width in meters For Wall 3");
                int Width3 = Convert.ToInt32(Console.ReadLine());
                int Area3 = (Length3 * Width3);



                int[] Walls = new int[nOW];
                Walls[0] = Area;
                Walls[1] = Area2;
                Walls[2] = Area3;

                for (int i = 0; i < Walls.Length; i++)
                {
                    Console.WriteLine("Wall " + Walls[i] + "m^2");
                }

                





                Console.WriteLine("Total Area For Wall 1: " + Area + "m^2");
                //Paint covers 25square meters
                float Paint = 25;
                float Required = (Area / Paint);
                //Paint Cost £5
                float Cost = 5;
                Console.WriteLine("Required Paint : " + Math.Round(Required));


                Console.WriteLine("Total Area For Wall 2 : " + Area2 + "m^2");
                //Paint covers 25square meter

                float Required2 = (Area2 / Paint);
                //Paint Cost £5

                Console.WriteLine("Required Paint : " + Math.Round(Required2));




                int workerFee = 100;
                if (Area >= 100)

                {
                    Console.WriteLine("Paint Cost For Wall 1: £" + ((Math.Round(Required) * Cost)));
                    Console.WriteLine("Total Cost For Wall 1: £" + ((Math.Round(Required) * Cost) + workerFee));

                    Console.WriteLine(" [Result: You will Need to hire an expert] ");
                }
                else if (Area >= 40)
                {
                    Console.WriteLine("You can do it with your friends");
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                }
                else if (Area == 0)
                { Console.WriteLine("Invalid"); }
                else
                {
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                    Console.WriteLine("You can do it Yourself");
                }


                if (Area2 >= 100)

                {
                    Console.WriteLine("Paint Cost For Wall 2: £" + ((Math.Round(Required2) * Cost)));
                    Console.WriteLine("Total Cost For Wall 2: £" + ((Math.Round(Required2) * Cost) + workerFee));

                    Console.WriteLine(" [Result: You will Need to hire an expert] ");
                }
                else if (Area2 >= 40)
                {
                    Console.WriteLine("You can do it with your friends (Wall 2)");
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required2) * Cost)));
                }
                else if (Area2 == 0)
                { Console.WriteLine("Invalid"); }
                else
                {
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required2) * Cost)));

                    Console.WriteLine("You can do it Yourself (Wall2)");
                }
           

            
            }
           else if (nOW ==2)
            {
                //Wall 1
                Console.WriteLine("Input Your Length in meters For Wall 1");
                int Length = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input Your Width in meters For Wall 1");
                int Width = Convert.ToInt32(Console.ReadLine());
                int Area = (Length * Width);

                //Wall 2
                Console.WriteLine("Input Your Length in meters For Wall 2");
                int Length2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input Your Width in meters For Wall 2");
                int Width2 = Convert.ToInt32(Console.ReadLine());
                int Area2 = (Length2 * Width2);

          



                int[] Walls = new int[nOW];
                Walls[0] = Area;
                Walls[1] = Area2;
                

                for (int i = 0; i < Walls.Length; i++)
                {
                    Console.WriteLine("Wall " + Walls[i] + "m^2");
                }







                Console.WriteLine("Total Area For Wall 1: " + Area + "m^2");
                //Paint covers 25square meter
                float Paint = 25;
                float Required = (Area / Paint);
                //Paint Cost £5
                float Cost = 5;
                Console.WriteLine("Required Paint : " + Math.Round(Required));


                Console.WriteLine("Total Area For Wall 2 : " + Area2 + "m^2");
                //Paint covers 25square meter

                float Required2 = (Area2 / Paint);
                //Paint Cost £5

                Console.WriteLine("Required Paint : " + Math.Round(Required2));




                int workerFee = 100;
                if (Area >= 100)

                {
                    Console.WriteLine("Paint Cost For Wall 1: £" + ((Math.Round(Required) * Cost)));
                    Console.WriteLine("Total Cost For Wall 1: £" + ((Math.Round(Required) * Cost) + workerFee));

                    Console.WriteLine(" [Result: You will Need to hire an expert] ");
                }
                else if (Area >= 40)
                {
                    Console.WriteLine("You can do it with your friends");
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                }
                else if (Area == 0)
                { Console.WriteLine("Invalid"); }
                else
                {
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                    Console.WriteLine("You can do it Yourself");
                }


                if (Area2 >= 100)

                {
                    Console.WriteLine("Paint Cost For Wall 2: £" + ((Math.Round(Required2) * Cost)));
                    Console.WriteLine("Total Cost For Wall 2: £" + ((Math.Round(Required2) * Cost) + workerFee));

                    Console.WriteLine(" [Result: You will Need to hire an expert] ");
                }
                else if (Area2 >= 40)
                {
                    Console.WriteLine("You can do it with your friends (Wall 2)");
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required2) * Cost)));
                }
                else if (Area2 == 0)
                { Console.WriteLine("Invalid"); }
                else
                {
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required2) * Cost)));

                    Console.WriteLine("You can do it Yourself (Wall2)");
                }






            }
            else if (nOW==1)
            {  //Wall 1
                Console.WriteLine("Input Your Length in meters For Wall 1");
                int Length = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input Your Width in meters For Wall 1");
                int Width = Convert.ToInt32(Console.ReadLine());
                int Area = (Length * Width);

            

                int[] Walls = new int[nOW];
                Walls[0] = Area;
               


                for (int i = 0; i < Walls.Length; i++)
                {
                    Console.WriteLine("Wall " + Walls[i] + "m^2");
                }




                Console.WriteLine("Total Area For Wall 1: " + Area + "m^2");
                //Paint covers 25square meter
                float Paint = 25;
                float Required = (Area / Paint);
                //Paint Cost £5
                float Cost = 5;
                Console.WriteLine("Required Paint : " + Math.Round(Required));


         


                int workerFee = 100;
                if (Area >= 100)

                {
                    Console.WriteLine("Paint Cost For Wall 1: £" + ((Math.Round(Required) * Cost)));
                    Console.WriteLine("Total Cost For Wall 1: £" + ((Math.Round(Required) * Cost) + workerFee));

                    Console.WriteLine(" [Result: You will Need to hire an expert] ");
                }
                else if (Area >= 40)
                {
                    Console.WriteLine("You can do it with your friends");
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                }
                else if (Area == 0)
                { Console.WriteLine("Invalid"); }
                else
                {
                    Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                    Console.WriteLine("You can do it Yourself");
                }


               
                



            }
            else 
            { Console.WriteLine("Invalid"); } 
                

            Console.ReadKey();
        }
    }
}
