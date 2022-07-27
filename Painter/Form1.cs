using System.Timers;
using System.Xml.Linq;
using Newtonsoft.Json.Serialization;
using Painter.Base;
using Painter.Controls;
using Painter.Enums;
using Painter.Interfaces;
using Painter.Shapes;
using Rectangle = Painter.Shapes.Rectangle;

namespace Painter
{
    public partial class Form1 : Form
    {
        public ShapeTypeEnum EditShapeType { get; set; }
        public IShape SelectedShape { get; set; }
        public ActionEnum Action { get; set; }

        public Form1()
        {
            InitializeComponent();
        }


        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Canvas.ReadFile();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Canvas.SaveFile();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Canvas.Clear();
        }
        

        private void SelectColor(object sender, EventArgs e)
        {
            var colorbutton = ((PainterColor)sender);
            Canvas.SelectedColor = colorbutton.Color;

            foreach (var control in FlwColors.Controls)
            {
                ((PainterColor)control).FlatAppearance.BorderSize = 0;
            }
            colorbutton.FlatAppearance.BorderColor = Color.Red;
            colorbutton.FlatAppearance.BorderSize = 2;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Action = ActionEnum.SELECT;
            BtnEdit.BackColor = SystemColors.Control;
            BtnSelect.BackColor = Color.Green;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Action = ActionEnum.EDIT;
            BtnEdit.BackColor = Color.Green;
            BtnSelect.BackColor = SystemColors.Control;
        }

        private Point StartMousePoz;
        private Point StartShapePoz;
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Action)
            {
                case ActionEnum.EDIT:
                    Canvas.Point1 = e.Location;
                    break;
                case ActionEnum.SELECT:
                    SelectedShape = Canvas.SelectShape(e.X, e.Y);
                    if (SelectedShape != null)
                    {
                        StartMousePoz = e.Location;
                        StartShapePoz = SelectedShape.Location;
                        switch (SelectedShape.Color.Name)
                        {
                            case "Red":
                                SelectColor(BtnRed,new EventArgs());
                                break;
                            case "Blue":
                                SelectColor(BtnBlue, new EventArgs());
                                break;
                            case "Green":
                                SelectColor(BtnGreen, new EventArgs());
                                break;
                            case "Brown":
                                SelectColor(BtnBrown, new EventArgs());
                                break;
                            case "Purple":
                                SelectColor(BtnPurple, new EventArgs());
                                break;
                            case "Orange":
                                SelectColor(BtnOrange, new EventArgs());
                                break;
                            case "Black":
                                SelectColor(BtnBlack, new EventArgs());
                                break;
                        }

                        switch (SelectedShape.ShapeType)
                        {
                            case ShapeTypeEnum.RECTANGLE:
                                Select_ShapeType(BtnRectangle,new EventArgs());
                                break;
                            case ShapeTypeEnum.CIRCLE:
                                Select_ShapeType(BtnCircle, new EventArgs());
                                break;
                            case ShapeTypeEnum.TRIANGLE:
                                Select_ShapeType(BtnTriangle, new EventArgs());
                                break;
                            case ShapeTypeEnum.HEXAGON:
                                Select_ShapeType(BtnHexagon, new EventArgs());
                                break;
                        }
                    }
                    break;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (Action == ActionEnum.SELECT)
            {
                if (SelectedShape != null)
                {

                    var farkx = StartMousePoz.X - StartShapePoz.X;
                    var farky = StartMousePoz.Y - StartShapePoz.Y;

                    int x = e.X - farkx, y = e.Y - farky;

                    if (x + SelectedShape.Size.Width > Canvas.Size.Width)
                        x = Canvas.Size.Width - SelectedShape.Size.Width;
                    else if (x < 0) x = 0;

                    if (y + SelectedShape.Size.Height > Canvas.Size.Height)
                        y = Canvas.Size.Height - SelectedShape.Size.Height;
                    else if (y < 0) y = 0;

                    SelectedShape.Location = new Point(x, y);

                    Canvas.InsertGraphics();
                    Canvas.Refresh();
                }
            }
        }

        private void Select_ShapeType(object sender, EventArgs e)
        {
            var buton = ((Button)sender);
            buton.FlatAppearance.BorderColor = Color.Red;
            foreach (Control flwShapesControl in FlwShapes.Controls)
            {
                ((Button)flwShapesControl).FlatAppearance.BorderSize = 0;
            }
            buton.FlatAppearance.BorderSize = 2;
            EditShapeType = (ShapeTypeEnum)byte.Parse(buton.Tag.ToString());
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Action)
            {
                case ActionEnum.EDIT:
                    Canvas.Point2 = e.Location;
                    var location = new Point(Canvas.Point1.X <= Canvas.Point2.X ? Canvas.Point1.X : Canvas.Point1.Y,
                        Canvas.Point1.Y <= Canvas.Point2.Y ? Canvas.Point1.Y : Canvas.Point2.Y);

                    var size = new Size(Math.Abs(Canvas.Point2.X - Canvas.Point1.X), Math.Abs(Canvas.Point2.Y - Canvas.Point1.Y));

                    if (EditShapeType == ShapeTypeEnum.RECTANGLE)
                        Canvas.AddShape(new Rectangle(location, size));
                    else if (EditShapeType == ShapeTypeEnum.CIRCLE)
                        Canvas.AddShape(new Circle(location, size));
                    else if (EditShapeType == ShapeTypeEnum.HEXAGON)
                        Canvas.AddShape(new Hexagon(location, size));
                    else if (EditShapeType == ShapeTypeEnum.TRIANGLE)
                        Canvas.AddShape(new Triangle(location, size));
                    break;
                case ActionEnum.SELECT:

                    SelectedShape = null;
                    Canvas.selectedshape = null;
                    Canvas.InsertGraphics();
                    Canvas.Refresh();
                    break;
            }
        }
    }
}