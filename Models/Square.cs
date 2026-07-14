using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2._3.Models
{
    internal class Square : Shape
    {
        public double SideLength { get; set; }

        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
