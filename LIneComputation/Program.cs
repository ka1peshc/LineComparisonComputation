using System;

namespace LIneComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison computation");
            Console.WriteLine("Enter Points according x1 y1 x2 y2 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double lineDistance;
            int temp1 = x1 - x2;
            int temp2 = y1 - y2;
            lineDistance = Math.Pow(temp1,2) + Math.Pow(temp2,2);
            lineDistance = Math.Sqrt(lineDistance);
            Console.WriteLine("Line distance is " + lineDistance);
        }
    }
}
