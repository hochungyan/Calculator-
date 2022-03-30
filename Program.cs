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
            Console.WriteLine("Input Your Length");
            int Length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Your Width");
            int Width = Convert.ToInt32(Console.ReadLine());
            float Area = (Length * Width);
            Console.WriteLine("Total Area : " + Area);
            //Paint covers 25square meter
            float Paint = 25;
            float Required = (Area / Paint);
          
           Console.WriteLine("Required Paint : " + Math.Round(Required));
   

            if (Area >= 50)
            { Console.WriteLine("You will Need to hire an expert "); }
           else if (Area >= 40)
            { Console.WriteLine("You can do it with your friends"); }
            else if (Area == 0)
            { Console.WriteLine("Invalid"); }
            else
            { Console.WriteLine("You can do it Yourself"); }

            Console.ReadKey();
        }
    }
}
