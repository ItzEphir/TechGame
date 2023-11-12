using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGame.Screens
{
    internal interface Screen
    {
        void Update();

        void Draw();

        void MousePressed(MouseButtonEventArgs args);
    }
}
