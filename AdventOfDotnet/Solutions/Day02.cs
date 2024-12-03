using System.Globalization;

namespace AdventOfDotnet.Solutions;

public class Day02 : IDaySolution
{
    public string Day => "02";

    public string SolvePart1(string input)
    {
        var lines = input.Split("\n");
        var safeCount = 0;
        foreach (var line in lines)
        {
            var numbers = line.Split(" ").Select(int.Parse).ToList();

            ReportLevelDirection direction = ReportLevelDirection.NotSet;
            var isSafe = true;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var distance = numbers[i] - numbers[i + 1];

                if (i == 0) direction = distance > 0 ? ReportLevelDirection.Ascending : ReportLevelDirection.Descending;

                var isDistanceZero = distance == 0;
                var isDistanceGreaterThan3 = Math.Abs(distance) > 3;
                var isDistanceInOppositeDirection = (direction == ReportLevelDirection.Descending && distance > 0) || (direction == ReportLevelDirection.Ascending && distance < 0);

                if (isDistanceZero || isDistanceGreaterThan3 || isDistanceInOppositeDirection)
                {
                    isSafe = false;
                    break;
                }
            }

            if (isSafe) safeCount++;
        }
        return safeCount.ToString();
    }

    public string SolvePart2(string input)
    {
        throw new NotImplementedException();
    }
}

enum ReportLevelDirection
{
    NotSet,
    Ascending,
    Descending
}