using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public class Game
    {
        public Snake Snake { get; private set; }
        private Food Food { get; set; }
        private Random Random { get; set; } = new Random();
        private ConsoleKeyInfo Direction { get; set; }

        public Game(Snake snake)
        {
            Snake = snake;
            Food = PlaceFood();
        }

        public void Start()
        {
            PrintSnake();
            PrintFood(Food);
            do
            {
                Direction = Console.ReadKey();

                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(250);

                    Move(Direction);
                }

            } while (true);
        }

        private void Move(ConsoleKeyInfo direction)
        {
            if (CheckForCollision())
            {
                Console.Clear();
                Console.WriteLine("GAME OVER");

                return;
            }

            var elementToRemove = Snake.SnakeBody[0];
            Snake.SnakeBody.Remove(elementToRemove);

            if (direction.Key == ConsoleKey.RightArrow)
            {
                var elementToAdd = new Coordinates(Snake.SnakeBody[Snake.SnakeBody.Count - 1].X + 1, Snake.SnakeBody[Snake.SnakeBody.Count - 1].Y);
                Snake.SnakeBody.Add(elementToAdd);
            }
            else if (direction.Key == ConsoleKey.DownArrow)
            {
                var elementToAdd = new Coordinates(Snake.SnakeBody[Snake.SnakeBody.Count - 1].X, Snake.SnakeBody[Snake.SnakeBody.Count - 1].Y + 1);
                Snake.SnakeBody.Add(elementToAdd);
            }
            else if (direction.Key == ConsoleKey.LeftArrow)
            {
                var elementToAdd = new Coordinates(Snake.SnakeBody[Snake.SnakeBody.Count - 1].X - 1, Snake.SnakeBody[Snake.SnakeBody.Count - 1].Y);
                Snake.SnakeBody.Add(elementToAdd);
            }
            else if (direction.Key == ConsoleKey.UpArrow)
            {
                var elementToAdd = new Coordinates(Snake.SnakeBody[Snake.SnakeBody.Count - 1].X, Snake.SnakeBody[Snake.SnakeBody.Count - 1].Y - 1);
                Snake.SnakeBody.Add(elementToAdd);
            }
            else
            {
                // TODO
            }

            Console.Clear();
            PrintSnake();
        }

        private bool CheckForCollision()
        {
            var snakeHead = Snake.GetHead();

            for (int i = 0; i < Snake.SnakeBody.Count - 1; i++)
            {
                if (snakeHead.X == Snake.SnakeBody[i].X && snakeHead.Y == Snake.SnakeBody[i].Y)
                {
                    return true;
                }
            }

            if (CollisionWithFood())
            {
                Console.Clear();
                PrintSnake();
                Eat();
            }

            return false;
        }

        private void Eat()
        {
            var newElementToAdd = new Coordinates(Food.X, Food.Y);
            Snake.SnakeBody.Add(newElementToAdd);
            Food = PlaceFood();

            Console.Clear();
            PrintSnake();
        }

        private bool CollisionWithFood()
        {
            var snakeHead = Snake.GetHead();

            if (Food.X == snakeHead.X && Food.Y == snakeHead.Y)
            {
                return true;
            }

            return false;
        }

        private void PrintSnake()
        {
            foreach (var element in Snake.SnakeBody)
            {
                Console.SetCursorPosition(element.X, element.Y);
                Console.Write("■");
            }

            PrintFood(Food);
        }

        private void PrintFood(Food food)
        {
            Console.SetCursorPosition(food.X, food.Y);
            Console.Write("#");
        }

        private Food PlaceFood()
        {
            return new Food(Random.Next(0, Constants.Width - 1), Random.Next(0, Constants.Height - 1));
        }
    }
}
