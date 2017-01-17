using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesArea
{
    public abstract class Shape
    {
        public double result;
        public abstract Shape CalculateArea(params double[] vals);
        
        public double Display()
        {
            return result;
        }
    }

    //Area Calculation for Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override Shape CalculateArea(params double[] vals)
        {
            if (vals.Length != 1)
                throw new Exception("Enter one value");
            if (vals[0] <= 0 || vals[0] > double.MaxValue)
                throw new Exception("Enter the value within the range of double");
            else
            {
                Radius = vals[0];
                result = Math.PI * Radius * Radius;
            }
            return this;
        }
    }

    //Area Calculation for Rectangle
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override Shape CalculateArea(params double[] vals)
        {
            if (vals.Length != 2)
                throw new Exception("Enter two value");
            if ((vals[0] <= 0 || vals[0] > double.MaxValue) || (vals[1] <= 0 || vals[1] > double.MaxValue))
                throw new Exception("Enter the value within the range of double");
            else
            {
                Length = vals[0];
                Width = vals[1];
                result = vals[0] * vals[1];
            }
            return this;
        }
    }

    //Area Calculation for Triangle
    public class Triangle : Shape
    {
        public double Base1 { get; set; }
        public double Height { get; set; }

        public override Shape CalculateArea(params double[] vals)
        {
            if (vals.Length != 2)
                throw new Exception("Enter two values");
            if ((vals[0] <= 0 || vals[0] > double.MaxValue) || (vals[1] <= 0 || vals[1] > double.MaxValue))
                throw new Exception("Enter the value within the range of double");
            else
            {
                Base1 = vals[0];
                Height = vals[1]; 
                result = 0.5 * vals[0] * vals[1];
            }
            return this;
        }
    }

    //class to return an instance
    public class ShapeFactory
    {
        public static Shape GetShape(string ch)
        {
            switch(ch)
            {
                case "Circle": return new Circle();
                case "Rectangle": return new Rectangle();
                case "Triangle": return new Triangle();
                default:throw new Exception("Invalid Choice");
            } 
        }
    }

    //main program
    class Program
    {
        static void Main(string[] args)
        {
            string choice, val;
            while (true)
            {
                Console.WriteLine("\nEnter a choice\n * Circle\n * Rectangle\n * Triangle\n * Exit");
                choice = Console.ReadLine();
                if (choice == "Exit")
                    Environment.Exit(0);

                Shape shape = ShapeFactory.GetShape(choice);

                Console.WriteLine("Enter the value :");
                val = Console.ReadLine();
                double[] values = Array.ConvertAll(val.Split(' '), Double.Parse);
                Console.WriteLine("Area Is : {0}", shape.CalculateArea(values).Display());

            }
        }
    }
}
