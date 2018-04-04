using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Roots
    {
        public double X1 { get; set; }
        public double? X2 { get; set; }
    }
    class Program
    {
        public static Roots QuadrationEqualReturnRoots(double a, double b, double c)
        {

            double d = b * b - 4 * a * c;

            if (d < 0)
                throw new Exception("D < 0");
            if (d == 0)
                return new Roots
                {
                    X1 = -(b / 2 * a),
                    X2 = null
                };
            return new Roots
            {
                X1 = (-b + Math.Sqrt(d)) / (2 * a),
                X2 = (-b - Math.Sqrt(d)) / (2 * a)
            };
        }
        public static double[] QuadrationEqual(double a, double b, double c)
        {
            
            double d = b * b - 4 * a * c;

            if (d < 0)
                throw new Exception("D < 0");
            if (d == 0)
                return new double[] { -(b / 2 * a) };
            return new double[]
            {
                (-b + Math.Sqrt(d)) / (2 * a),
                (-b - Math.Sqrt(d)) / (2 * a)

            };
        }


        static void Main(string[] args)
        {
            try
            {
                foreach (double i in QuadrationEqual(1, 2, -3))
                    Console.WriteLine(i);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();
        }
    }
}
