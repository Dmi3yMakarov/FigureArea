using FigureArea.Intyerfaces;
using FigureArea.Shapes;

namespace FigureArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new(5.0);
            Console.WriteLine(circ.ToString());       // 78.540
            Console.WriteLine(circ.GetArea);          // 78,53981633

            Triangle triangle = new(60, 91, 109);
            Console.WriteLine(triangle.ToString());   // 2730.000
            Console.WriteLine(triangle.IsRightTriangle());    // True
        }
    }
}