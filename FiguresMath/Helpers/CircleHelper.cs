namespace FiguresMath.Helpers
{
    public static class CircleHelper
    {
        public static double GetArea(double radius) => Math.PI * Math.Pow(radius, 2);
        public static double GetPerimeter(double radius) => 2 * Math.PI * radius;
    }
}
