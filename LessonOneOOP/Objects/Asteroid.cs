using System.Drawing;

namespace LessonOneOOP
{
    /// <summary>
    /// Астероид
    /// </summary>
    internal class Asteroid : Star
    {
        private static readonly Image[] AsteroidImages;
        /// <summary> Количество разновидностей астероидов </summary>
        public static int CountImages { get; }
        static Asteroid()
        {
            Image[] tmpImages =
            {
                Image.FromFile("C:\\Users\\miniB\\RiderProjects\\GeekBrains\\LessonOneOOP\\Images\\Asteroid1.png"),
                Image.FromFile("C:\\Users\\miniB\\RiderProjects\\GeekBrains\\LessonOneOOP\\Images\\Asteroid2.png"),
                Image.FromFile("C:\\Users\\miniB\\RiderProjects\\GeekBrains\\LessonOneOOP\\Images\\Asteroid3.png"),
                Image.FromFile("C:\\Users\\miniB\\RiderProjects\\GeekBrains\\LessonOneOOP\\Images\\Asteroid4.png"),
                Image.FromFile("C:\\Users\\miniB\\RiderProjects\\GeekBrains\\LessonOneOOP\\Images\\Asteroid5.png")
            };
            AsteroidImages = tmpImages;
            CountImages = tmpImages.Length;
        }
        private int _currentImages;
        public Asteroid(Point pos, Point dir, Size size, int currentImages) : base(pos, dir, size)
        {
            _currentImages = currentImages;
        }
        /// <summary> Обновление астероида </summary>
        public override void Update()
        {
            Pos.X += Dir.X;
            Pos.Y += Dir.Y;
            if (Pos.X + Size.Width >= 0) return;
            Pos.X = Game.Width + Size.Width + Game.Rand.Next(Game.Width);
            Pos.Y = Game.Rand.Next(Game.Height - Size.Height);
            _currentImages = Game.Rand.Next(CountImages);
        }
        /// <summary> Отрисовка астероида </summary>
        public override void Draw(Graphics g)
        {
            g.DrawImage(AsteroidImages[_currentImages], new Rectangle(Pos, Size));
        }
    }
}