namespace FiguresMath.Helpers
{
    public static class ShapeWithSidesHelper
    {
        /// <summary>
        /// Function to get any shapes with straight sides perimeter
        /// </summary>
        /// <param name="sides">Sides of a shape</param>
        /// <returns>Perimeter value</returns>
        public static double GetPerimeter(double[] sides) => sides.Sum();
    }
}
