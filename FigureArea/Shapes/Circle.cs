namespace FigureArea.Shapes
{
    public class Circle : AShape
    {
        /// <summary>
        /// Get Circle Area
        /// </summary>
        /// <param name="r">Radius</param>
        public Circle(double r) : base(Math.PI * r * r) 
        {
            if (r <= 0.0)
                throw new ArgumentException("Radius is not positive value");
        }
    }
}
