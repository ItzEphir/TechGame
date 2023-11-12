using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace TechGame.Drawables
{
    internal class GameField : Drawable
    {
        public List<Cell> Cells = new List<Cell>();

        public GameField(RenderWindow window)
        {
            _size = (Vector2f)window.Size;
            _shape = new RectangleShape(_size)
            {
                FillColor = Color.White
            };
            _lines = new List<Line>();
            AppendCells();
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(_shape);
            DrawLines(window);
            DrawCells(window);
        }

        private void DrawLines(RenderWindow window)
        {
            _lines.ForEach(line =>
            {
                line.Draw(window);
            });
        }

        private void DrawCells(RenderWindow window)
        {
            Cells.ForEach(cell =>
            {
                cell.Draw(window);
            });
        }

        private void AppendCells()
        {
            for (int i = 0; i < _size.X; i += 40)
            {
                _lines.Add(new Line(new Vector2f(i, 0), new Vector2f(i, _size.Y)));
            }

            for (int i = 0; i < _size.Y; i += 40)
            {
                _lines.Add(new Line(new Vector2f(0, i), new Vector2f(_size.X, i)));
            }

            for (int i = 0; i < _size.Y; i += 40)
            {
                for(int j = 0; j < _size.X; j += 40)
                {
                    Cells.Add(new Cell(new Vector2f(j, i)));
                }
            }
        }

        private readonly Vector2f _size;
        private readonly RectangleShape _shape;
        private readonly List<Line> _lines;
    }
}
