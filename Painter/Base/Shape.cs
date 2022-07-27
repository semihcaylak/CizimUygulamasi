using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Painter.Enums;
using Painter.Interfaces;
using Rectangle = System.Drawing.Rectangle;

namespace Painter.Base
{
    public abstract class Shape : IShape
    {
        private Point _location =  new Point(10, 10);
        private Size _size = new Size(200, 200);

        public Point Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                SelectRectangle = new Rectangle(_location.X-5, _location.Y-5, _size.Width+10, _size.Height+10);
            }
        }
        public Size Size {
        get
        {
            return _size;
        }
        set
        {
            _size = value;
            SelectRectangle = new Rectangle(_location.X - 5, _location.Y - 5, _size.Width + 10, _size.Height + 10);
        }}
        public Color Color { get; set; } = Color.Green;
        public ShapeTypeEnum ShapeType { get; set; }
        public Point[] Points { get; set; }
        public Rectangle  SelectRectangle { get; set; }
        

        public Shape()
        {
            SelectRectangle = new Rectangle(Location.X - 5, Location.Y - 5, Size.Width + 10, Size.Height + 10);
        }

    }
}
