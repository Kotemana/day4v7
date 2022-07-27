namespace day4v7
{
    public class ColorManager
    {
        public ColorModel ColorModel { get; set; }
        public string GetColor(int floors, int blankFloors, int lineWidth, int floor)
        {
            string color;

            if (floor <= blankFloors)
            {
                color = ColorModel.BlankLine;
            }
            else if (floor <= blankFloors + lineWidth)
            {
                color = ColorModel.BottomLine;
            }
            else if (floor > floors - lineWidth)
            {
                color = ColorModel.TopLine;
            }
            else
            {
                color = ColorModel.MiddleLine;
            }

            return color;
        }

        public void SetConsoleColor(string color)
        {
            switch (color.ToLower())
            {
                case "blank":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                default:
                    break;
            }
        }
    }
}
