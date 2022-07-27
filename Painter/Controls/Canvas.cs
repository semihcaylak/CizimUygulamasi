using System.Drawing.Drawing2D;
using Newtonsoft.Json;
using Painter.Base;
using Painter.Enums;
using Painter.Interfaces;

namespace Painter.Controls
{
    public class Canvas : Panel
    {
        public List<IShape> Shapes { get; set; }
        public ShapeTypeEnum SelectedShape { get; set; } = ShapeTypeEnum.RECTANGLE;
        public Color SelectedColor { get; set; } = Color.Black;

        private JsonSerializerSettings setting;

        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public Canvas()
        {
            setting = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore
            };

            this.BackColor = Color.White;
            this.Paint += Canvas_Paint;
        }

        private void Canvas_Paint(object? sender, PaintEventArgs e)
        {
            InsertGraphics();
        }
        public void AddShape(Shape shape)
        {
            if (Shapes == null) Shapes = new List<IShape>();
            shape.Color = SelectedColor;
            this.Shapes.Add(shape);
            InsertGraphic(shape);
        }

        public IShape selectedshape { get; set; }
        private void Select(IShape shape)
        {
            using (Graphics g = this.CreateGraphics())
            {
                var brush = new SolidBrush(Color.FromArgb(50, Color.Chocolate));
                g.FillRectangle(brush, shape.SelectRectangle);
                selectedshape = shape;
            }
        }
        public void SaveFile()
        {
            using (var dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonConvert.SerializeObject(Shapes, setting);
                    File.WriteAllText(dialog.FileName, json);
                }
            }
        }

        public void ReadFile()
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var jsonstring = File.ReadAllText(dialog.FileName);

                    Shapes = JsonConvert.DeserializeObject<List<IShape>>(jsonstring, setting);
                    InsertGraphics();
                }
            }
        }
        public void InsertGraphic(IShape shape)
        {
            Graphics g = this.CreateGraphics();

            var brush = new SolidBrush(shape.Color);

            if (shape.ShapeType == ShapeTypeEnum.CIRCLE)
            {
                var graphicPath = new GraphicsPath();
                graphicPath.AddEllipse(shape.Location.X, shape.Location.Y, shape.Size.Width, shape.Size.Height);
                g.FillPath(brush, graphicPath);
            }
            else if (shape.ShapeType == ShapeTypeEnum.HEXAGON)
                g.FillPolygon(brush, shape.Points);
            else if (shape.ShapeType == ShapeTypeEnum.RECTANGLE)
            {
                g.FillRectangle(brush, shape.Location.X, shape.Location.Y, shape.Size.Width, shape.Size.Height);
            }
            else
            {
                var byteArr = new byte[shape.Points.Length];
                for (int i = 0; i < byteArr.Length; i++)
                {
                    byteArr[i] = 1;
                }
                g.FillPath(brush, new GraphicsPath(shape.Points, byteArr));
            }

            g.Dispose();
        }

        public void InsertGraphics()
        {
            if (Shapes != null)
                using (Graphics g = this.CreateGraphics())
                {
                    foreach (var shape in Shapes)
                    {
                        var brush = new SolidBrush(shape.Color);

                        if (shape.ShapeType == ShapeTypeEnum.CIRCLE)
                        {
                            var graphicPath = new GraphicsPath();
                            graphicPath.AddEllipse(shape.Location.X, shape.Location.Y, shape.Size.Width, shape.Size.Height);
                            g.FillPath(brush, graphicPath);
                        }
                        else if (shape.ShapeType == ShapeTypeEnum.HEXAGON)
                            g.FillPolygon(brush, shape.Points);
                        else
                        {
                            var byteArr = new byte[shape.Points.Length];
                            for (int i = 0; i < byteArr.Length; i++)
                            {
                                byteArr[i] = 1;
                            }
                            g.FillPath(brush, new GraphicsPath(shape.Points, byteArr));
                        }
                    }
                    if (selectedshape != null)
                        g.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Chocolate)),
                           selectedshape.SelectRectangle);
                }

        }



        public void Clear()
        {
            if (Shapes != null)
                Shapes.Clear();
            this.Refresh();
        }

        public IShape SelectShape(int X, int Y)
        {
            if (Shapes != null)
                foreach (var shape in Shapes)
                {
                    if (X <= shape.Size.Width + shape.Location.X &&
                        X >= shape.Location.X &&
                        Y <= shape.Size.Height + shape.Location.Y &&
                        Y >= shape.Location.Y
                       )
                    {
                        Select(shape);
                        return shape;

                    }
                }

            return default;
        }
    }
}
