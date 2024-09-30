using static FiguresMath.Helpers.ShapeWithSidesHelper;

namespace FiguresMath.Shapes.Base
{
    public abstract record ShapeWithSides : Shape
    {
        public double[] Sides { get; }

        public virtual double Perimeter => GetPerimeter(Sides);
        public double SemiPerimeter => Perimeter / 2;

        protected ShapeWithSides(double[] sides)
        {
            Sides = sides;
        }
    }
}
