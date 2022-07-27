namespace day4v7
{
    public class FlatSelector
    {
        public int Floors { get; set; }
        public int Entrances { get; set; }
        public int FlatsOnFloor { get; set; }
       
        public FlatSelector(int fl, int ent, int flf)
        {
            Floors = fl;
            Entrances = ent;
            FlatsOnFloor = flf;
        }

        public FlatSelector() 
        { 
        }

        public int BlankFloors
        {
            get { return Floors % 3; }     // Calculated property
        }

        public int LineWidth => Floors / 3; // Другая форма calculated property

        public void ShowFlatsColors(ColorModel colorModel)
        {
            int flat = 0;
            string color = "not yet defined";
            ColorManager colorManager = new ColorManager() 
            {
                ColorModel = colorModel
            };
            for (int ent = 1; ent <= Entrances; ent++)
            {
                for (int floor = 1; floor <= Floors; floor++)
                {
                    color = colorManager.GetColor(Floors, BlankFloors, LineWidth, floor);
                    for (int floorFlat = 1; floorFlat <= FlatsOnFloor; floorFlat++)
                    {
                        flat++;
                        Console.WriteLine($"Hello flat #{flat}. Your color is {color}");
                    }
                }
            }

        }

        public void ShowFlag(ColorModel colorModel)
        {
            string color = "not yet defined";
            var currentNumber = 0;
            ColorManager colorManager = new ColorManager()
            {
                ColorModel = colorModel
            };
            for (int floor = Floors; floor > 0; floor--)
            {
                for (int window = 1; window <= FlatsOnFloor * Entrances; window++)
                {
                    currentNumber++;
                    color = colorManager.GetColor(Floors, BlankFloors, LineWidth, floor);
                    colorManager.SetConsoleColor(color);
                    Console.Write("*");
                    if (currentNumber % FlatsOnFloor == 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
