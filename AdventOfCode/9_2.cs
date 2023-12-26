namespace AdventOfCode;

public class _9_2 {
    public static int Execute()
    {
        var lines = File.ReadLines("/Users/mervyn/Projects/AdventOfCode2023/AdventOfCode/Inputs/9.txt");

        var sum = 0;

        foreach (var line in lines)
        {
            var list = line.Split(' ').Select(int.Parse).ToList();
            sum += GetFirst(list);
        }

        return sum;
    }

    public static int GetFirst(List<int> range)
    {
        var newRange = new List<int>();
        for (int i = 0; i < range.Count - 1; i++)
        {
            int difference = range[i + 1] - range[i];
            newRange.Add(difference);
        }

        if (newRange.Any(x => x != 0))
        {
            var result = range.First() - GetFirst(newRange);
            return result;
        }
        else
        {
            var result = range.First() - newRange.Last();
            return result;
        }
    }
}