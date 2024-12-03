using AdventOfDotnet.Solutions;

namespace AdventOfDotnet.Tests;

public class Day02Test
{
    [Fact]
    public void Test_SolvePart1_SafeWhenDecreasing()
    {
        // Arrange
        var sut = new Day02();
        var content = "7 6 4 2 1";

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("1", actual);
    }

    [Fact]
    public void Test_SolvePart1_SafeWhenIncreasing()
    {
        // Arrange
        var sut = new Day02();
        var content = "1 3 6 7 9";

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("1", actual);
    }

    [Fact]
    public void Test_SolvePart1_UnsafeWhenIncreasingTooMuch()
    {
        // Arrange
        var sut = new Day02();
        var content = "1 2 7 8 9";

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("0", actual);
    }

    [Fact]
    public void Test_SolvePart1_UnsafeWhenDecreasingTooMuch()
    {
        // Arrange
        var sut = new Day02();
        var content = "9 7 6 2 1";

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("0", actual);
    }

    [Fact]
    public void Test_SolvePart1_UnsafeWhenIncreasingAndDecreasing()
    {
        // Arrange
        var sut = new Day02();
        var content = "1 3 2 4 5";

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("0", actual);
    }

    [Fact]
    public void Test_SolvePart1_UnsafeWhenNoChange()
    {
        // Arrange
        var sut = new Day02();
        var content = "8 6 4 4 1";

        // Act
        var actual = sut.SolvePart1(content);

        // Assert
        Assert.Equal("0", actual);
    }
}
