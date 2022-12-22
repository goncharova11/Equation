using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public class Equation
    {
        static void Main(string[] args)
        {
            double a;
            do
            {
                Console.WriteLine("Введите значение a, не равное нулю");
                double m = double.Parse(Console.ReadLine());
                a = m;
            }
            while (a == 0);

            Console.WriteLine("Введите значение b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            double c = double.Parse(Console.ReadLine());

            double D = Diskriminant(a, b, c);

            if (D > 0) SquareRoots(D, a, b);
            if (D == 0) SquareRoot(a, b);
            else Console.WriteLine("Нет корней");
            
        }
        public static double Diskriminant (double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            return D;
        }
               
        public static double[] SquareRoots(double D, double a, double b) 
        {
            double[] result = new double[]
                {
                    (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a)
                };

            Console.WriteLine(Convert.ToString(result[0]));
            Console.WriteLine(Convert.ToString(result[1]));
            return result;
        }
        public static double SquareRoot(double a, double b)
        { 
            double x1= (-b) / (2 * a);
            return x1;
        }
    }
}
