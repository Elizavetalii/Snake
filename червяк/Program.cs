namespace snake
{
    internal static class Program
    {
        public static void Main(string[] a)
        {
            Console.SetCursorPosition(5, 12);
            Console.WriteLine("Добро пожаловать в игру счастливая змейка!");
            Thread.Sleep(4000);
            Actions actions = new Actions();
            Console.CursorVisible = false;
            Snake snake = new Snake();
            Food food = new Food();
            Borders output = new Borders();
            Thread inputThread = new Thread(new ThreadStart(snake.MoveByInput));
            output.PrintBorders();
            inputThread.Start();
            while (true)
            {
                Thread.Sleep(100);
                if (!food.FoodGenerated)
                {
                    food.GenerateFood(snake);
                }
                snake.EatFruit(food);
                snake.BodyCoordinates.Remove(snake.BodyCoordinates.Last());
                snake.UpdateHeadByDefault();
                output.ClearField();
                output.PrintFruit(food);
                output.PrintSnake(snake);
                Console.SetCursorPosition(2, 25);
                if (Actions.SnakeOnBorders(snake) || Actions.SnakeEatsItself(snake))
                {
                    Console.SetCursorPosition(18, 12);
                    Console.WriteLine("Ваша змейка погибла...");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }

            }
        }
    }
}