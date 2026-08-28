using System.Globalization;
using System.Runtime.CompilerServices;

namespace AutoSDK.Generation;

internal static class IndentedString
{
    public static string Create(
        int indentationLevel,
        [InterpolatedStringHandlerArgument(nameof(indentationLevel))] ref IndentedStringHandler handler)
    {
        return handler.GetFormattedText();
    }
}

[InterpolatedStringHandler]
internal ref struct IndentedStringHandler
{
    private readonly PooledStringBuilder builder;
    private readonly int indentationLength;
    private bool atLineStart;

    public IndentedStringHandler(int literalLength, int formattedCount, int indentationLevel)
    {
#if NET8_0_OR_GREATER
        ArgumentOutOfRangeException.ThrowIfNegative(indentationLevel);
#else
        if (indentationLevel < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(indentationLevel));
        }
#endif

        builder = new PooledStringBuilder(Math.Max(literalLength, 256));
        indentationLength = checked(indentationLevel * 4);
        atLineStart = true;
    }

    public void AppendLiteral(string value)
    {
        Append(value);
    }

    public void AppendFormatted(string? value)
    {
        Append(value);
    }

    public void AppendFormatted<T>(T value)
    {
        Append(value?.ToString());
    }

    public void AppendFormatted<T>(T value, string? format)
    {
        Append(value is IFormattable formattable
            ? formattable.ToString(format, CultureInfo.CurrentCulture)
            : value?.ToString());
    }

    public string GetFormattedText()
    {
        var result = builder.ToString();
        Dispose();
        return result;
    }

    public void Dispose()
    {
        builder.Dispose();
    }

    private void Append(string? value)
    {
        if (value is not { Length: > 0 })
        {
            return;
        }

        var segmentStart = 0;
        for (var index = 0; index < value.Length; index++)
        {
            if (value[index] != '\n')
            {
                continue;
            }

            AppendSegment(value, segmentStart, index - segmentStart, appendLineFeed: true);
            segmentStart = index + 1;
        }

        if (segmentStart < value.Length)
        {
            AppendSegment(value, segmentStart, value.Length - segmentStart, appendLineFeed: false);
        }
    }

    private void AppendSegment(string value, int startIndex, int count, bool appendLineFeed)
    {
        if (count > 0)
        {
            if (atLineStart && indentationLength > 0)
            {
                builder.Append(' ', indentationLength);
            }

            builder.Append(value, startIndex, count);
            atLineStart = false;
        }

        if (appendLineFeed)
        {
            builder.Append('\n');
            atLineStart = true;
        }
    }
}
