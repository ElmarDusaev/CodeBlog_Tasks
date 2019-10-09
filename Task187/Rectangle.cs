using System.Drawing;

namespace Task187
{
    class Rectangle : Shape
    {
        public Rectangle(int posX, int posY, int width, int height, Color backColor, Graphics Graphics) : base(posX, posY, width, height, backColor, Graphics)
        {
        }
        public Rectangle()
        {

        }
        public override void Draw()
        {
            Brush = new SolidBrush(BackColor);
            Rectangle = new System.Drawing.Rectangle(PosX, PosY, Width, Height);
            
            Graphics.FillRectangle(Brush, Rectangle);

        }
    }

}
