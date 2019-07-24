using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Constants.Width, Constants.Height);
            Console.CursorVisible = false;

            Snake snake = new Snake();
            Game game = new Game(snake);
            game.Start();
        }
    }
}
