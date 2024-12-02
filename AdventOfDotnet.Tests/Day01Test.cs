using AdventOfDotnet.Solutions;
using System.Text;

namespace AdventOfDotnet.Tests;

public class Day01Test
{
    [Fact]
    public void Test_SolvePart1_WhenOnePair()
    {
        // Arrange
        var sut = new Day01();
        var content = GenerateInput([
            (3,4)
        ]);

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("1", actual);
    }

    [Fact]
    public void Test_SolvePart1_WhenManyPairs()
    {
        // Arrange
        var sut = new Day01();
        var content = GenerateInput([ 
            (3,4),
            (4,3), 
            (2,5), 
            (1,3), 
            (3,9), 
            (3,3) 
        ]);

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("11", actual);
    }

    [Fact]
    public void Test_SolvePart2_WhenZeroOccurrences()
    {
        // Arrange
        var sut = new Day01();
        var content = GenerateInput([
            (1,4),
            (2,5),
            (3,6),
        ]);

        // Act
        var actual = sut.SolvePart2(content);

        // Assert
        Assert.Equal("0", actual);
    }

    [Fact]
    public void Test_SolvePart2_WhenOneOccurrence()
    {
        // Arrange
        var sut = new Day01();
        var content = GenerateInput([
            (1,3),
            (2,5),
            (3,6),
        ]);

        // Act
        var actual = sut.SolvePart2(content);

        // Assert
        Assert.Equal("3", actual);
    }

    [Fact]
    public void Test_SolvePart2_WhenManyOccurrenceForOneLeftEntries()
    {
        // Arrange
        var sut = new Day01();
        var content = GenerateInput([
            (1,3),
            (2,3),
            (3,6),
        ]);

        // Act
        var actual = sut.SolvePart2(content);

        // Assert
        Assert.Equal("6", actual);
    }

    [Fact]
    public void Test_SolvePart2_WhenManyOccurrenceForMultipleLeftEntries()
    {
        // Arrange
        var sut = new Day01();
        var content = GenerateInput([
            (3,4),
            (4,3),
            (2,5),
            (1,3),
            (3,9),
            (3,3)
        ]);

        // Act
        var actual = sut.SolvePart2(content);

        // Assert
        Assert.Equal("31", actual);
    }

    private static string GenerateInput(IEnumerable<(int, int)> pairs)
    {
        var builder = new StringBuilder();

        foreach (var (left, right) in pairs)
        {
            builder.Append($"{left}   {right}\r\n");
        }

        return builder.ToString();
    }
}
