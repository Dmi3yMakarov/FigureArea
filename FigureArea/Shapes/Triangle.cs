namespace FigureArea.Shapes
{
    public class Triangle : AShape
    {
        private List<double> _sides;

        /// <summary>
        /// Get Triangle Area
        /// </summary>
        /// <param name="a">A side length of a triangle</param>
        /// <param name="b">B side length of b triangle</param>
        /// <param name="c">C side length of c triangle</param>
        public Triangle(double a, double b, double c) 
            : base(Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Sides length is not a positive value");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Sides do not form a triangle");
            _sides = new List<double>
            {
                a,
                b,
                c
            };
        }

        /// <summary>
        /// Triangle is Right
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsRightTriangle()
        {
            double eps = 1E-6;
            _sides.Sort();
            return Math.Abs(Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) - Math.Pow(_sides[2], 2)) <= eps;
        }              
    }
}
