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
            Console.WriteLine("Input Your Length in m");
            int Length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Your Width in m");
            int Width = Convert.ToInt32(Console.ReadLine());
            float Area = (Length * Width);
            Console.WriteLine("Total Area : " + Area +"m^2");
            //Paint covers 25square meter
            float Paint = 25;
            float Required = (Area / Paint);
            //Paint Cost £5
            float Cost = 5;
            Console.WriteLine("Required Paint : " + Math.Round(Required));
            
            int workerFee = 100;
            if (Area >= 100)

            {
                Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                Console.WriteLine("Total Cost : £" + ((Math.Round(Required) * Cost) + workerFee));

                Console.WriteLine("You will Need to hire an expert "); }
           else if (Area >= 40)
            { Console.WriteLine("You can do it with your friends");
                Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
            }
            else if (Area == 0)
            { Console.WriteLine("Invalid"); }
            else
            {
                Console.WriteLine("Paint Cost : £" + ((Math.Round(Required) * Cost)));
                Console.WriteLine("You can do it Yourself"); }

            Console.ReadKey();
        }
    }
}
