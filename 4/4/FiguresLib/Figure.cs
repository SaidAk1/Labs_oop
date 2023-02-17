﻿namespace FiguresLib
{
    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;

        public string name;
        
        public Figure(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
        abstract public void Draw();
        abstract public bool Coords_check(int x, int y);
        virtual public void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
            this.DeleteF(this, false);
            this.Draw();
        }
        public void DeleteF(Figure figure, bool flag = true)
        {
            ShapeContainer.figureList.Remove(figure);
            Init.Clear();
            Init.mainCanvas.Image = Init.bitmap;
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
            if (flag == false)
            {
                ShapeContainer.figureList.Add(figure);
            }
        }
        public virtual string Name
        {
            get { return name; }
        }
    }
}
