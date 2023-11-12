using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGame.Drawables
{
    internal class Line : Drawable
    {
        public Line(Vector2f start, Vector2f end)
        {
            _verticies = new VertexArray(PrimitiveType.Lines, 2);
            _verticies[0] = new Vertex()
            {
                Position = start,
                Color = new Color(150, 150, 150)
            };
            _verticies[1] = new Vertex() 
            {
                Position = end, 
                Color = new Color(150, 150, 150) 
            };
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(_verticies);
        }

        private VertexArray _verticies;
    }
}
