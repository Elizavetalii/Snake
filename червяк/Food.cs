namespace snake
{
    internal class Food
    {
        public bool FoodGenerated;
        public (int, int) FoodCoordinate;
        public void GenerateFood (Snake snake)
        {
            Random random = new Random();
            int x, y;
            x = random.Next(1, 25);
            y = random.Next(1, 25);
            if (!snake.BodyCoordinates.Contains((x, y)))
            {
                FoodGenerated = true;
            }
            FoodCoordinate = (x, y);
        }
    }
}