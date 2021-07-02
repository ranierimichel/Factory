using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        public class Point
        {
            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho*Math.Cos(theta), rho*Math.Sin(theta));
            }

            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            private double x, y;

            private Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"{nameof(x)}: {x}{Environment.NewLine}{nameof(y)}: {y}";
            }

        }       

        public 

        static void Main(string[] args)
        {
            var point = Point.NewPolarPoint(12, 5);
            Console.WriteLine(point);
            var point1 = Point.NewCartesianPoint(12, 5);
            Console.WriteLine(point1);
        }
    }
}
