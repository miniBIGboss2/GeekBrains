using System;
using System.Drawing;
using System.Windows.Forms;

namespace LessonOneOOP
{
    /// <summary>
    /// Менеджер игры
    /// </summary>
    internal static class Game
    {
        private static BufferedGraphicsContext _context;
        private static BufferedGraphics _buffer;
        public static int Width { get; private set; }
        public static int Height { get; private set; }
        public static readonly Random Rand = new Random();
        /// <summary> Звезды на фоне </summary>
        private static BaseObject[] _fonStars;
        /// <summary> Астероиды </summary>
        private static BaseObject[] _asteroids;
        static Game()
        {
        }
        public static void Init(Form form)
        {
            _context = BufferedGraphicsManager.Current;
            var g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            _buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();
            var timer = new Timer {Interval = 10};
            timer.Tick += (sender, args) =>
            {
                Update();
                Draw();
            };
            timer.Start();
        }
        /// <summary> Загрузка элементов в начальном состоянии </summary>
        private static void Load()
        {
            _fonStars = new BaseObject[150];
            for (var i = 0; i < 120; i++) //мелкие звезды
            {
                var randomSize = Rand.Next(3, 9);
                var speed = randomSize / 3;
                _fonStars[i] = new Star(new Point(Rand.Next(Width - randomSize), 
                    Rand.Next(Height - randomSize)), 
                    new Point(-speed,0), new Size(randomSize,randomSize));
            }
            for (var i = 120; i < 150; i++) //крупные звезды
            {
                var randomSize = Rand.Next(10, 20);
                var speed = randomSize / 4;
                _fonStars[i] = new Star(new Point(Rand.Next(Width - randomSize), 
                    Rand.Next(Height - randomSize)), 
                    new Point(-speed,0), new Size(randomSize,randomSize));
            }
            _asteroids = new BaseObject[10];
            for (var i = 0; i < _asteroids.Length; i++)
                _asteroids[i] = new Asteroid(new Point(Width + Rand.Next(Width), 
                    Rand.Next(Height - 30)), new Point(-6,0), 
                    new Size(40,40),Rand.Next(Asteroid.CountImages));
        }
        /// <summary> Обновление всех элементов </summary>
        private static void Update()
        {
            foreach (var star in _fonStars)
                star.Update();
            foreach (var asteroid in _asteroids)
                asteroid.Update();
        }
        /// <summary> Отрисовка всех элементов в окне </summary>
        public static void Draw()
        {
            _buffer.Graphics.Clear(Color.Black);
            foreach (var star in _fonStars)
                star.Draw(_buffer.Graphics);
            foreach (var asteroid in _asteroids)
                asteroid.Draw(_buffer.Graphics);
            _buffer.Render();
        }
    }
}