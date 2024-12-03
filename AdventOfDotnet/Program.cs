using AdventOfDotnet;

var register = new DaySolutionRegistry();
var availableDays = register.GetSolutionDays();

Console.WriteLine("Advent of .NET");
Console.WriteLine("Day Solutions");
foreach (var day in availableDays)
{
    Console.WriteLine($"[] Day {day}");
}

string? dayInput = null;
while (dayInput is null)
{
    Console.WriteLine();
    Console.Write("Select a day: ");
    dayInput = Console.ReadLine();

    if (dayInput is null)
    {
        Console.WriteLine("Day cannot be null");
        continue;
    }

    if (!availableDays.Any(d => d.Equals(dayInput)))
    {
        Console.WriteLine($"Day {dayInput} not registered with solutions");
        dayInput = null;
    }
}


Console.WriteLine();
Console.WriteLine("[] Part 1");
Console.WriteLine("[] Part 2");

SolutionPart? part = null;
while (part is null)
{
    Console.WriteLine();
    Console.Write("Select a part: ");
    var partInput = Console.ReadLine();

    if (partInput is null)
    {
        Console.WriteLine("Solution Part cannot be null");
        continue;
    }

    part = partInput switch
    {
        "1" => SolutionPart.Part1,
        "2" => SolutionPart.Part2,
        _ => null
    };

    if (part is null) Console.WriteLine("Solution Part must be either 1 or 2");
}

if (part is null) { throw new Exception("Part is null"); }
Console.WriteLine(register.RunSolution(dayInput, part.GetValueOrDefault()));



