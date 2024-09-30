using static FiguresMath.Helpers.ShapeWithSidesHelper;

namespace FiguresMath.Helpers
{
    public static class TriangeHelper
    {
        public static double GetArea(double[] sides)
        {
            double semiPerimeter = GetPerimeter(sides) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
        }

        public static bool IsRectangular(double sideA, double sideB, double sideC)
        {
            double[] sides = { sideA, sideB, sideC };

            return sides.Select((length, index) => (length, index))
                        .Any(side => side.length == Math.Sqrt(sides.Where((subLength, subIndex) => subIndex != side.index)
                                                                 .Select(s => Math.Pow(s, 2))
                                                                 .Sum()));
        }
    }
}
