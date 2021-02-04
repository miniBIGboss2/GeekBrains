using System.Drawing;
using System.Windows.Forms;

namespace LessonOneOOP
{
    /// <summary>
    /// Меню-заставка игры
    /// </summary>
    internal static class SplashScreen
    {
        private static Form _myForm;
        private static int Width { get; set; }

        public static void Init(Form form)
        {
            _myForm = form;
            Width = form.ClientSize.Width;
            var labelHeader = new Label
            {
                Size = new Size(800,50),
                Location = new Point((Width-800)/2,20),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 160)
            };
            form.Controls.Add(labelHeader);
            var labelHead = new Label
            {
                Text = "Игра \"Астероиды\"",
                Size = new Size(500,50),
                Location = new Point((Width-500)/2,180),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 160)
            };
            form.Controls.Add(labelHead);
            var buttonGame = new Button
            {
                Text = "Начало игры",
                Size = new Size(400,50),
                Location = new Point((Width-400)/2,250),
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 160)
            };
            buttonGame.Click += (sender, args) =>
            {
                _myForm.Controls.Clear();
                Game.Init(_myForm);
                _myForm.Show();
                Game.Draw();
            };
            form.Controls.Add(buttonGame);
            var buttonExit = new Button
            {
                Text = "Выход",
                Size = new Size(400,50),
                Location = new Point((Width-400)/2,390),
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 160)
            };
            buttonExit.Click += (sender, args) =>
            {
                _myForm.Close();
            };
            form.Controls.Add(buttonExit);
            var labelAbout = new Label
            {
                Size = new Size(500,50),
                Location = new Point((Width-500)/2,500),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 160)
            };
            form.Controls.Add(labelAbout);
        }
    }
}