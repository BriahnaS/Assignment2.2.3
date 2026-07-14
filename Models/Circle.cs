using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2._3.Models
{
    internal class Circle : Shape
    {
        public double CircleRadius { get; set; }

        public override double CalculateArea()
        {
            double area = Math.PI * CircleRadius * CircleRadius;
            return area;
        }
    }
}
