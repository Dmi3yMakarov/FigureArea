using FigureArea.Intyerfaces;

namespace FigureArea.Shapes
{
    public abstract class AShape : IShape
    {
        private readonly double _area;
        public double GetArea() => _area;
        protected AShape(double area) => this._area = area;
        public override string ToString() =>
            $"Shape type: {this.GetType().Name}, Area = {_area:F3}";
    }
}
