using AbstractClassExercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWithHeritage.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
