using Painter.Base;
using Painter.Enums;

namespace Painter.Shapes
{
    public class Triangle : Shape
    {
        public Triangle()
        {
            ShapeType = ShapeTypeEnum.TRIANGLE;
            SetPoints();
        }

        public Triangle( Point location, Size size)
        {
            ShapeType = ShapeTypeEnum.TRIANGLE;
            Location = location;
            Size = size;
            SetPoints();
        }

        private void SetPoints()
        {
            Points = new Point[]
            {
                new Point(Size.Width / 2 + Location.X, Location.Y),
                new Point(Location.X + Size.Width, Location.Y + Size.Height),
                new Point(Location.X, Location.Y + Size.Height)
            };
        }
    }
}
