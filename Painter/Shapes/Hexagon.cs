using System.Text.Json.Serialization;
using Painter.Base;
using Painter.Enums;

namespace Painter.Shapes
{
    public class Hexagon:Shape
    {
        [JsonConstructor]
        public Hexagon()
        {
            ShapeType = ShapeTypeEnum.HEXAGON;
            SetPoints();
        }

        public Hexagon( Point location, Size size)
        {
            ShapeType = ShapeTypeEnum.HEXAGON;
            Location = location;
            Size = size;
            SetPoints();
        }
        private void SetPoints()
        {
            Points = new Point[]
            {
                new Point(Location.X + Size.Width / 4, Location.Y),
                new Point(Location.X + Size.Width / 4 * 3, Location.Y),
                new Point(Location.X + Size.Width, Location.Y + Size.Height / 2),
                new Point(Location.X + Size.Width / 4 * 3, Location.Y + Size.Height),
                new Point(Location.X+Size.Width/4,Location.Y+Size.Height),
                new Point(Location.X,Location.Y+Size.Height/2)
            };
        }
    }
}
