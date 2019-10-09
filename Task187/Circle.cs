using System.Drawing;

namespace Task187
{
    class Circle : Shape
    {
        public Circle(int posX, int posY, int width, int height, Color backColor, Graphics Graphics) : base(posX, posY, width, height, backColor, Graphics)
        {
        }

        public override void Draw()
        {
            Brush = new SolidBrush(BackColor);
            Rectangle = new System.Drawing.Rectangle(PosX, PosY, Width, Height);
            Graphics.FillEllipse(Brush, Rectangle);

        }

        public Circle()
        {

        }
    }

}
