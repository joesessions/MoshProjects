﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle { Width = 100, Height = 100 });
            shapes.Add(new Rectangle() );

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}