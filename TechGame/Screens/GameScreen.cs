using SFML.Graphics;
using SFML.System;
using SFML.Window;
using TechGame.Buildings;
using TechGame.Drawables;

namespace TechGame.Screens
{
    internal class GameScreen : Screen
    {
        public GameScreen(RenderWindow window)
        {
            _window = window;
            _field = new GameField(_window);
        }

        public void Draw()
        {
            _field.Draw(_window);
        }

        public void Update()
        {

        }

        public void MousePressed(MouseButtonEventArgs args)
        {
            var mousePosition = Mouse.GetPosition(_window);
            int cellNum = mousePosition.Y / 40 * (int)(_window.Size.X / 40) + mousePosition.X / 40;
            Console.WriteLine(mousePosition);
            Console.WriteLine(cellNum);
            Console.WriteLine();
            var button = args.Button;
            if (button == Mouse.Button.Left)
            {
                _field.Cells[cellNum].Building = new Mine();
            }
        }

        private readonly GameField _field;
        private readonly RenderWindow _window;
    }
}
