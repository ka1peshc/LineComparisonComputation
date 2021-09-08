using System;
using System.Collections.Generic;
using System.Text;

namespace LIneComputation
{
    class CalculateDistance
    {
        private int x1, x2, y1, y2;
        private double dist;
        
        public void takeCartesiaPoint()
        {
            Console.WriteLine("Enter Points according x1 y1 x2 y2 ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public double computeDistance()
        {
            int temp1 = x1 - x2;
            int temp2 = y1 - y2;
            dist = Math.Pow(temp1, 2) + Math.Pow(temp2, 2);
            dist = Math.Sqrt(dist);
            return dist;
        }

    }
}
