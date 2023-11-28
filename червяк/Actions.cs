namespace snake
{
    internal class Actions
    {
        public Actions()
        {
            #pragma warning disable CA1416 
            Console.WindowHeight = 27;
            Console.WindowWidth = 52;
        }
        public static bool SnakeOnBorders(Snake snake)
        {
            (int x, int y) = snake.BodyCoordinates.First();
            return x == 0 || y == 0 || x >= 25 || y >= 25;
        }
        public static bool SnakeEatsItself(Snake snake)
        {
            for (int i = 4; i < snake.BodyCoordinates.Count; i++)
            {
                if (snake.BodyCoordinates.First() == snake.BodyCoordinates[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}