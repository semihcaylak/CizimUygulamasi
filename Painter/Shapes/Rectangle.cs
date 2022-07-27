using Painter.Base;
using Painter.Enums;

namespace Painter.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            ShapeType = ShapeTypeEnum.RECTANGLE;
            SetPoints();
        }

        public Rectangle(Point location, Size size)
        {
            ShapeType = ShapeTypeEnum.RECTANGLE;
            Location = location;
            Size = size;
            SetPoints();
        }


        private void SetPoints()
        {
            Points = new Point[]
              {
                new Point(Location.X,Location.Y),
                new Point(Location.X+Size.Width,Location.Y),
                new Point(Location.X+Size.Width,Location.Y+Size.Height),
                new Point(Location.X,Location.Y+Size.Height)
              };
        }
    }
}
