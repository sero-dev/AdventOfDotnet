using System.Text.RegularExpressions;

namespace AdventOfDotnet.Solutions;

/// <summary>
/// Day 1: Historian Hysteria - The Chief Historian is always present for the big Christmas sleigh launch, but nobody has seen him in months! Last anyone heard, he was visiting locations that are historically significant to the North Pole; a group of Senior Historians has asked you to accompany them as they check the places they think he was most likely to visit. 
/// </summary>
public class Day01 : IDaySolution
{
    public string Day => "01";

    public string SolvePart1(string input)
    {
        var lines = input.Split("\n");
        var pattern = "(\\d+)\\s+(\\d+)";

        var leftList = new List<int>();
        var rightList = new List<int>();

        foreach (var line in lines)
        {
            var matches = Regex.Match(line, pattern);
            if (!matches.Success) continue;

            var left = int.Parse(matches.Groups[1].Value ?? throw new Exception($"Left number could not be found on {line}"));
            var right = int.Parse(matches.Groups[2].Value ?? throw new Exception($"Right number could not be found on {line}"));

            leftList.Add(left);
            rightList.Add(right);
        }

        if (leftList.Count != rightList.Count) throw new Exception("List are not equal");

        leftList.Sort();
        rightList.Sort();

        var count = 0;
        for(int i = 0; i < leftList.Count; i++) 
        {
            count += Math.Abs(leftList[i] - rightList[i]);
        }

        return count.ToString();
    }

    public string SolvePart2(string input)
    {
        var occurences = new Dictionary<int, int>();
        var leftList = new List<int>();

        var lines = input.Split("\r\n");
        var pattern = "^(\\d+)\\s+(\\d+)$";

        foreach (var line in lines)
        {
            var matches = Regex.Match(line, pattern);
            if (!matches.Success) continue;

            var left = int.Parse(matches.Groups[1].Value ?? throw new Exception($"Left number could not be found on {line}"));
            var right = int.Parse(matches.Groups[2].Value ?? throw new Exception($"Right number could not be found on {line}"));

            leftList.Add(left);

            if (occurences.TryGetValue(right, out int value)) occurences[right] = ++value;
            else occurences[right] = 1;
        }

        var count = 0;
        foreach (var item in leftList)
        {
            if (occurences.TryGetValue(item, out int value)) count += item * value;
            else continue;
        }

        return count.ToString();
    }
}
