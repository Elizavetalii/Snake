namespace snake
{
    internal class Borders
    {
        readonly string Snake = "0";
        readonly string Head = "\u263A";
        readonly string Food = "$";
        private (int, int) ConvertToOutputCoordinate((int, int) coordinate)
        {
            (int x, int y) = coordinate;
            return (x * 2, y);
        }
        public void PrintBorders()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("$");
            }
            Console.SetCursorPosition(0, 25);
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("$");
            }
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('$');
            }
            for (int i = 0; i <= 25; i++)
            {
                Console.SetCursorPosition(50, i);
                Console.Write('$');
            }
        }
        public void PrintSnake(Snake snake)
        {
            foreach ((int, int) coordinate in snake.BodyCoordinates)
            {
                (int consoleX, int consoleY) = ConvertToOutputCoordinate(coordinate);
                Console.SetCursorPosition(consoleX, consoleY);
                Console.Write(coordinate == snake.BodyCoordinates.First() ? Head : Snake);
            }
        }
        public void PrintFruit(Food fruit)
        {
            (int consoleX, int consoleY) = ConvertToOutputCoordinate(fruit.FoodCoordinate);
            Console.SetCursorPosition(consoleX, consoleY);
            Console.Write(Food);
        }
        public void ClearField()
        {
            for (int i = 1; i < (int)Border.UpDown; i++)
            {
                Console.SetCursorPosition(1, i);
                for (int j = 0; j < (int)Border.LeftRight - 1; j++)
                {
                    Console.Write(' ');
                }
            }
        }
    }
}