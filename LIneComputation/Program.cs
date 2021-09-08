using System;

namespace LIneComputation
{
    class Program: CalculateDistance
    {
        string DisplayLinesRelation(double line1,double line2)
        {
            string result;
            if (line1 == line2)
            {
                result="Lines are equal";
            }
            else if (line1 > line2)
            {
                result="line 1 is bigger line 2";
            }
            else
            {
                result="line 2 is bigger line 1";
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison computation");

            double line1, line2;
            Program p = new Program();
            p.takeCartesiaPoint();
            line1 = p.computeDistance();
            Console.WriteLine("Line distance is " + line1);

            p.takeCartesiaPoint();
            line2 = p.computeDistance();
            Console.WriteLine("Line distance is " + line2);

            Console.WriteLine(p.DisplayLinesRelation(line1, line2));

        }
    }
}
