using System.Drawing;

namespace LessonOneOOP
{
    /// <summary>
    /// Базовая фигура пространства
    /// </summary>
    internal class BaseObject
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;
        protected BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }
        /// <summary>
        /// Обновление объекта - заглушки
        /// </summary>
        public virtual void Update()
        {
            Pos.X += Dir.X;
            Pos.Y += Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X + Size.Width > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y + Size.Height > Game.Height) Dir.Y = -Dir.Y;
        }
        /// <summary>
        /// Отрисовка объекта - заглушки
        /// </summary>
        public virtual void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.White, new Rectangle(Pos,Size));
        }
    }
}