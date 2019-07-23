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
    }
}
