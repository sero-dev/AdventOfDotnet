namespace AdventOfDotnet;

public interface IDaySolution
{
    public abstract string Day { get; }
    public abstract string SolvePart1(string input);
    public abstract string SolvePart2(string input);
}
