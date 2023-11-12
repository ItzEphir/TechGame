using SFML.Window;
using SFML.Graphics;
using SFML.System;


namespace TechGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var videoMode = new VideoMode(1920, 1080);

            var window = new RenderWindow(videoMode, "TechGame", Styles.Close);

            var main = new Main(window);

            window.Closed += (object? sender, EventArgs e) => (sender as RenderWindow)?.Close(); 

            window.MouseButtonPressed += (object? sender, MouseButtonEventArgs e) => main.MousePressed(e);

            while (window.IsOpen)
            {
                window.DispatchEvents();
                main.Update();
                window.Clear();
                main.Draw();
                window.Display();
            }
        }
    }
}