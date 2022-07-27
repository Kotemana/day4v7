using day4v7;


int floors = GetIntFromInput("Enter number of floors:");
int entrances = GetIntFromInput("Enter number of Entrances:");
int flatsOnFloor = GetIntFromInput("Enter number of flats on the floor:");
// variant 1 without constructor
//var flatManager = new FlatSelector()
//{
//    Floors = floors,
//    Entrances = entrances,
//    FlatsOnFloor = flatsOnFloor
//};

// variant 2 without constructor
//flatManager.Floors = floors;
//flatManager.Entrances = entrances;
//flatManager.FlatsOnFloor = flatsOnFloor;

// variant with constructor
var flatManager = new FlatSelector(floors,entrances, flatsOnFloor);
Console.WriteLine($"So, your house will have {flatManager.Floors} floors {flatManager.Entrances} entrances {flatManager.FlatsOnFloor} flats on each floor");
Console.WriteLine($"And line width will be {flatManager.LineWidth}");
var belColorModel = new ColorModel
{
    BlankLine = "Blank",
    TopLine = "White",
    MiddleLine = "Red",
    BottomLine = "White"
};
var gerColorModel = new ColorModel
{
    BlankLine = "Blank",
    TopLine = "Yellow",
    MiddleLine = "Red",
    BottomLine = "Black"
};
flatManager.ShowFlag(belColorModel);
flatManager.ShowFlag(gerColorModel);

var smalFlagFlatSelector = new FlatSelector(3, 5, 1);
smalFlagFlatSelector.ShowFlag(gerColorModel);

int GetIntFromInput(string question)
{
    Console.WriteLine(question);
    var result = Console.ReadLine();
    return int.Parse(result);
}