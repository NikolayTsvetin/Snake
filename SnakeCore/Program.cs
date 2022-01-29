Console.WindowHeight = Constants.Height;
Console.WindowWidth = Constants.Width;

Console.SetBufferSize(Constants.Width, Constants.Height);
Console.CursorVisible = false;

Snake snake = new Snake();
Game game = new Game(snake);
game.Start();