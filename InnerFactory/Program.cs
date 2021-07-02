using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerFactory
{
    public class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}:{x}{Environment.NewLine}{nameof(y)}:{y}"; 
        }

        public static Point origin = new Point(0, 0);

        public static class Factory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var x = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(Point.origin);
            Console.WriteLine(x);
            
        }
    }
}
