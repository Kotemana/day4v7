/*

есть дом, в нем n подъездов, m этажей, k квартир на этаже, у каждой квартиры одно окно, мы можем попросить жителей в квартирах зажечь свет любого цвета или погасить свет
наша задача написать в дворовой чатик кто в какой квартире что зажигает, чтобы на доме получился флаг Беларуси


и потом еще вывести что получилось на экран звёздочками разных цветов, между подъездами отступ в 1 пробел


т.е. если входные параметры 3 этажа 3 падика 1 квартира - то будет
1-белый 2-красный 3-белый 4-белый ... 9- белый
и флажок из звездочек 3 на 3

Leonid, [7/5/2022 6:02 PM]
но количество падиков этажей и квартир на этаж вводится с клавиатуры
*/

const string topLine = "Green";
const string middleLine = "White";
const string bottomLine = "Red";
const string blankLine = "Blank";

int floors = GetIntFromInput("Enter number of floors:");



int entrances = GetIntFromInput("Enter number of Entrances:");
int flatsOnFloor = GetIntFromInput("Enter number of flats on the floor:");
Console.WriteLine($"So, your house will have {floors} floors {entrances} entrances {flatsOnFloor} flats on each floor");
ShowFlatsColors(floors, entrances, flatsOnFloor);



int GetIntFromInput(string question)
{
    Console.WriteLine(question);
    var result = Console.ReadLine();
    return int.Parse(result);
}

void ShowFlatsColors(int floors, int entrances, int flatsOnFloor)
{
    int flat = 0;
    int blankFloors = floors % 3; // % это остаток от деления
    int lineWidth = floors / 3;
    string color = "not yet defined";
    for (int ent = 1; ent <= entrances; ent++)
    {
        for (int floor = 1; floor <= floors; floor++)
        {
            color = GetColor(floors, blankFloors, lineWidth, floor);
            for (int floorFlat = 1; floorFlat <= flatsOnFloor; floorFlat++)
            {
                flat++;
                Console.WriteLine($"Hello flat #{flat}. Your color is {color}");
            }
        }
    }
    var currentNumber = 0;
    for (int floor = floors; floor > 0; floor--)
    {
        for (int window = 1; window <= flatsOnFloor * entrances; window++)
        {
            currentNumber++;
            color = GetColor(floors, blankFloors, lineWidth, floor);
            SetConsoleColor(color);
            Console.Write("*");
            if (currentNumber % flatsOnFloor == 0)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }


    string GetColor(int floors, int blankFloors, int lineWidth, int floor)
    {
        string color;

        if (floor <= blankFloors)
        {
            color = blankLine;
        }
        else if (floor <= blankFloors + lineWidth)
        {
            color = bottomLine;
        }
        else if (floor > floors - lineWidth)
        {
            color = topLine;
        }
        else
        {
            color = middleLine;
        }

        return color;
    }

    static void SetConsoleColor(string color)
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