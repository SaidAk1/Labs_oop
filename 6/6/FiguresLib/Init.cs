using System.Drawing;
using System.Windows.Forms;

namespace FiguresLib
{
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox mainCanvas;
        public static Pen pen;
        public static ListBox figuresListBox;
        public static BindingSource bs;
        public static  bool Coords_check(int x, int y, int w, int h)
        {
            if (!((x < 0) || (y < 0) || (x + w > Init.mainCanvas.Width) || (y + h > Init.mainCanvas.Height)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Coords_check(Point[] points, int x, int y)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if ((points[i].X + x < 0) || (points[i].Y + y < 0) || (points[i].X + x > Init.mainCanvas.Width) ||
                    (points[i].Y + y > Init.mainCanvas.Height))
                {
                    return false;
                }
            }
            return true;
        }
        public static void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }
}
