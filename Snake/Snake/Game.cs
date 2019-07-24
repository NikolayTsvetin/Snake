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
        private Food Food { get; set; }
        private Random Random { get; set; } = new Random();

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
                ConsoleKeyInfo direction = Console.ReadKey();

                Move(direction);
            } while (true);
        }

        private void Move(ConsoleKeyInfo direction)
        {
            var elementToRemove = Snake.SnakeBody[0];
            Snake.SnakeBody.Remove(elementToRemove);

            if (CollisionWithFood())
            {
                Eat();
            }

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

        private void Eat()
        {
            var newElementToAdd = new Coordinates(Snake.SnakeBody[0].X, Snake.SnakeBody[0].Y);
            Food = PlaceFood();
            Snake.SnakeBody.Add(newElementToAdd);
        }

        private bool CollisionWithFood()
        {
            var snakeHead = new Coordinates(Snake.SnakeBody[Snake.SnakeBody.Count - 1].X + 1, Snake.SnakeBody[Snake.SnakeBody.Count - 1].Y);

            if (Food.X == snakeHead.X && Food.Y == snakeHead.Y)
            {
                Console.WriteLine("Collision with food!");
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
