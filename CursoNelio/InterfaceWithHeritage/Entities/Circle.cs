﻿using AbstractClassExercise.Entities.Enums;
using InterfaceWithHeritage.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractClassExercise.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
