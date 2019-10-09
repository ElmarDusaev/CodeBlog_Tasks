using System.Drawing;

namespace Task187
{
    abstract class Shape
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Color BackColor { get; set; }
        public SolidBrush Brush { get; set; }
        public System.Drawing.Rectangle Rectangle { get; set; }
        public Graphics Graphics{ get; set; }
        protected Shape(int posX, int posY, int width, int height, Color backColor, Graphics graphics)
        {
            PosX = posX;
            PosY = posY;
            Width = width;
            Height = height;
            BackColor = backColor;
            Brush = new SolidBrush(BackColor);
            Rectangle = new System.Drawing.Rectangle(PosX, PosY, Width, Height);
            Graphics = graphics;
        }

        protected Shape()
        {
        }

        public abstract void Draw();
    }

}
