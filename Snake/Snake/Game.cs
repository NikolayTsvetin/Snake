using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Game
    {
        public Snake Snake { get; private set; }

        public Game(Snake snake)
        {
            Snake = snake;
        }

        public void Start()
        {
            PrintSnake();

            do
            {
                ConsoleKeyInfo direction = Console.ReadKey();

                Move(direction);
            } while (true);
        }

        private void Move(ConsoleKeyInfo direction)
        {
            if (direction.Key == ConsoleKey.RightArrow)
            {

            }
            else if (direction.Key == ConsoleKey.DownArrow)
            {

            }
            else if (direction.Key == ConsoleKey.LeftArrow)
            {

            }
            else if (direction.Key == ConsoleKey.UpArrow)
            {

            }
            else
            {
                // TODO
            }
        }

        private void PrintSnake()
        {
            foreach (var element in Snake.SnakeBody)
            {
                Console.SetCursorPosition(element.X, element.Y);
                Console.Write("0");
            }
        }
    }
}
