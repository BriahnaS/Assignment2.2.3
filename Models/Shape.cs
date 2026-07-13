using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2._3.Models
{
    internal class Shape // Base class
    {
        public string ShapeID { get; set; }
        public string ShapeName { get; set; }
        public string ShapeColor { get; set; }

        public virtual double? CalculateArea()
        {
            return null;
        }
    }
}
