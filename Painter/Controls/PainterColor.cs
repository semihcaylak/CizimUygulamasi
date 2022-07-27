namespace Painter.Controls
{
    public class PainterColor : Button
    {
        private Color _color;

        public Color Color { get; set; }


        public override Color BackColor
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
                base.BackColor = _color;
                Color = value;
            }
        }
    }
}
