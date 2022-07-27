using Painter.Base;
using Painter.Enums;

namespace Painter.Shapes
{
    public class Circle:Shape
    {
        public Circle()
        {
            ShapeType = ShapeTypeEnum.CIRCLE;
        }

        public Circle( Point location, Size size)
        {
            ShapeType = ShapeTypeEnum.CIRCLE;
            Location = location;
            Size = size;
        }
    }
}
