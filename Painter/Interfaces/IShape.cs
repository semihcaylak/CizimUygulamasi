using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Painter.Enums;
using Rectangle = System.Drawing.Rectangle;

namespace Painter.Interfaces
{
    public interface IShape
    {
        Point Location { get; set; }
        Size Size { get; set; }
        Color Color { get; set; }
        ShapeTypeEnum ShapeType { get; set; }
        Point[] Points { get; set; }
        Rectangle SelectRectangle { get; set; }
    }
}
