using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public List<Coordinates> SnakeBody { get; private set; }

        public Snake()
        {
            SnakeBody = new List<Coordinates>() { new Coordinates(0, 0), new Coordinates(1, 0), new Coordinates(2, 0) };
        }

        public Coordinates GetHead()
        {
            return new Coordinates(SnakeBody[SnakeBody.Count - 1].X, SnakeBody[SnakeBody.Count - 1].Y);
        }
    }
}
