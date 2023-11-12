using SFML.Graphics;
using SFML.System;
using System.Collections.Concurrent;
using TechGame.Buildings;

namespace TechGame.Drawables
{
    static class CellConstants
    {
        public static Dictionary<Type, Color> colors = new()
        {
            { typeof(Building.Empty), Color.Transparent },
            { typeof(Mine), Color.Blue }
        };
    }

    internal class Cell : Drawable
    {
        public Building Building 
        { 
            get => _building;
            set 
            { 
                _building = value;
                _shape.FillColor = CellConstants.colors[_building.GetType()];
            } 
        }

        public Cell(Vector2f position)
        {
            _position = position;
            _shape = new RectangleShape(new Vector2f(40, 40))
            {
                Position = _position,
                FillColor = CellConstants.colors[_building.GetType()]
            };
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(_shape);
        }

        private readonly Vector2f _position;
        private readonly RectangleShape _shape;
        private Building _building = new Building.Empty();
    }
}
