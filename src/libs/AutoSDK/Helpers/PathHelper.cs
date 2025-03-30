namespace AutoSDK.Helpers;

public static class PathHelper
{
    /// <summary>
    /// Extracts all names enclosed in '{}' using Span for performance
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static IReadOnlyCollection<string> ExtractParameters(ReadOnlySpan<char> input)
    {
        var result = new List<string>();

        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] != '{')
            {
                continue;
            }
            
            var start = i + 1;
            var end = input[start..].IndexOf('}');
            if (end <= 0)
            {
                continue;
            }
            
            result.Add(input.Slice(start, end).ToString());
            i = start + end;
        }

        return result;
    }
}