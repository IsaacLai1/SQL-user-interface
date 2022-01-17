
using System.Drawing;
using System.Windows.Forms;
namespace Project_Final_Semester2019
{
    class RoundConerButton : Button
    {
        private Color _boderColor = Color.Silver;
        private Color _onHoverBoderColor = Color.Gray;
        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;

        private bool _isHovering;
        private int _borderThickness = 6;
        private int _borderThicknessByTwo = 3;

        public RoundConerButton()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_isHovering ? _onHoverBoderColor : _boderColor);

            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);

            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness, Height - _borderThickness);
            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo, Width - Height - _borderThickness, Height - _borderThickness);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);

        }

        public Color BoderColor
        {
            get => _boderColor;
            set
            {
                _boderColor = value;
                Invalidate();
            }
        }
        public Color onHoverColorBoder
        {
            get => _onHoverBoderColor;
            set
            {
                _onHoverBoderColor = value;
                Invalidate();
            }
        }
        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }
        public Color _OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
    }
}
