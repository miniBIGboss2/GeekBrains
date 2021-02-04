using System.Drawing;

namespace LessonOneOOP
{
    /// <summary>
    /// Фоновая звезда
    /// </summary>
    internal class Star : BaseObject
    {
        private static readonly Image DrawImage = Image.FromFile("C:\\Users\\miniB\\RiderProjects\\GeekBrains\\LessonOneOOP\\Images\\Star.png");
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        } 
        /// <summary> Обновление звезды </summary>
        public override void Update()
        {
            Pos.X += Dir.X;
            if (Pos.X + Size.Width >= 0) return;
            Pos.X = Game.Width + Size.Width;
            Pos.Y = Game.Rand.Next(Game.Height - Size.Height);
        }
        /// <summary> Отрисовка звезды </summary>
        public override void Draw(Graphics g)
        {
            g.DrawImage(DrawImage, new Rectangle(Pos, Size));
        }
    }
}