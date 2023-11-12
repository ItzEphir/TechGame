using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGame.Screens;

namespace TechGame
{
    internal class Main
    {
        public Main(RenderWindow window)
        {
            _window = window;
            _screen = new GameScreen(_window);
        }

        public void Update()
        {
            _screen.Update();
        }

        public void Draw()
        {
            _screen.Draw();
        }

        public void MousePressed(MouseButtonEventArgs args)
        {
            _screen.MousePressed(args);
        }

        private Screen _screen;

        private readonly RenderWindow _window;
    }
}
