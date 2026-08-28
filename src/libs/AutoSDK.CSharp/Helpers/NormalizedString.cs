using System.Globalization;
using System.Runtime.CompilerServices;

namespace AutoSDK.Generation;

internal static class NormalizedString
{
    public static string Create(ref NormalizedStringHandler handler)
    {
        return handler.GetFormattedText();
    }

    public static string Create(
        int indentationLevel,
        [InterpolatedStringHandlerArgument(nameof(indentationLevel))] ref NormalizedStringHandler handler)
    {
        return handler.GetFormattedText();
    }

    public static string Normalize(string value, int indentationLevel = 0)
    {
        return Create(indentationLevel, $"{value}");
    }
}

[InterpolatedStringHandler]
internal ref struct NormalizedStringHandler
{
    private readonly PooledStringBuilder builder;
    private int lineStart;
    private bool lineStarted;
    private bool lineHasNonWhitespace;
    private bool hasRetainedLine;
    private bool skipLineFeed;
    private readonly int indentationLength;

    public NormalizedStringHandler(int literalLength, int formattedCount)
    {
        builder = new PooledStringBuilder(Math.Max(literalLength, 256));
        lineStart = 0;
        lineStarted = false;
        lineHasNonWhitespace = false;
        hasRetainedLine = false;
        skipLineFeed = false;
        indentationLength = 0;
    }

    public NormalizedStringHandler(int literalLength, int formattedCount, int indentationLevel)
        : this(literalLength, formattedCount)
    {
#if NET8_0_OR_GREATER
        ArgumentOutOfRangeException.ThrowIfNegative(indentationLevel);
#else
        if (indentationLevel < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(indentationLevel));
        }
#endif

        indentationLength = checked(indentationLevel * 4);
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
        FinishLine();
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

        var index = 0;
        if (skipLineFeed)
        {
            skipLineFeed = false;
            if (value[0] == '\n')
            {
                index++;
            }
        }

        while (index < value.Length)
        {
            var segmentStart = index;
            while (index < value.Length && value[index] is not ('\r' or '\n'))
            {
                index++;
            }

            if (index > segmentStart)
            {
                BeginLine();
                var contentStart = lineStart + (hasRetainedLine ? 1 : 0);
                if (builder.Length == contentStart && indentationLength > 0)
                {
                    builder.Append(' ', indentationLength);
                }
                builder.Append(value, segmentStart, index - segmentStart);
                if (!lineHasNonWhitespace)
                {
                    for (var characterIndex = segmentStart; characterIndex < index; characterIndex++)
                    {
                        if (!char.IsWhiteSpace(value[characterIndex]))
                        {
                            lineHasNonWhitespace = true;
                            break;
                        }
                    }
                }
            }

            if (index == value.Length)
            {
                break;
            }

            var newline = value[index++];
            FinishLine();
            if (newline == '\r')
            {
                if (index < value.Length && value[index] == '\n')
                {
                    index++;
                }
                else if (index == value.Length)
                {
                    skipLineFeed = true;
                }
            }
        }
    }

    private void BeginLine()
    {
        if (lineStarted)
        {
            return;
        }

        lineStart = builder.Length;
        if (hasRetainedLine)
        {
            builder.Append('\n');
        }
        lineStarted = true;
    }

    private void FinishLine()
    {
        BeginLine();
        if (builder.Length > lineStart + (hasRetainedLine ? 1 : 0) && !lineHasNonWhitespace)
        {
            builder.Truncate(lineStart);
        }
        else
        {
            hasRetainedLine = true;
        }

        lineStarted = false;
        lineHasNonWhitespace = false;
    }
}
