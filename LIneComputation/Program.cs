using System;

namespace LIneComputation
{
    class Program
    {
        static double calDistance()
        {
            double dist=0;
            Console.WriteLine("Enter Points according x1 y1 x2 y2 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int temp1 = x1 - x2;
            int temp2 = y1 - y2;
            dist = Math.Pow(temp1, 2) + Math.Pow(temp2, 2);
            dist = Math.Sqrt(dist);
            return dist;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison computation");
            double line1 = calDistance();
            Console.WriteLine("Line distance is " + line1);
            double line2 = calDistance();
            Console.WriteLine("Line distance is " + line2);
            if (line1 == line2)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (line1 > line2)
            {
                Console.WriteLine("line 1 is bigger line 2");
            }
            else
            {
                Console.WriteLine("line 2 is bigger line 1");
            }

        }
    }
}
