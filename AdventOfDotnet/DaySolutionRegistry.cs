using System.Reflection;

namespace AdventOfDotnet;

internal class DaySolutionRegistry
{
    private Dictionary<string, IDaySolution> Solutions { get; } = [];

    public DaySolutionRegistry()
    {
        var baseType = typeof(IDaySolution);

        var derivedTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.IsClass && !t.IsInterface && baseType.IsAssignableFrom(t) && t.Namespace == nameof(AdventOfDotnet.Solutions));

        foreach (var derivedType in derivedTypes)
        {
            if (Activator.CreateInstance(derivedType) is  IDaySolution instance)
            {
                Solutions.Add(instance.Day, instance);
            }
        }
    }

    public List<string> GetSolutionDays()
    {
        return [.. Solutions.Keys];
    }

    public string RunSolution(string day, SolutionPart part)
    {
        var instance = Solutions[day];

        if (instance is null) throw new Exception($"Day Solution {day} was not registered");

        string content = File.ReadAllText(Path.Combine("Input", $"day{day}.txt"));
        return part switch
        {
            SolutionPart.Part1 => instance.SolvePart1(content),
            SolutionPart.Part2 => instance.SolvePart2(content),
            _ => throw new NotImplementedException()
        };
            
    }
}

internal enum SolutionPart
{
    Part1,
    Part2
}
