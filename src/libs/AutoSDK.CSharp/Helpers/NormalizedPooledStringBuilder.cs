namespace AutoSDK.Generation;

/// <summary>
/// Writes directly into a pooled buffer while removing whitespace-only lines.
/// This lets large render graphs share the final normalized buffer instead of
/// materializing each nested fragment as a separate string first.
/// </summary>
internal sealed class NormalizedPooledStringBuilder : PooledStringBuilder
{
    private int lineStart;
    private bool lineStarted;
    private bool lineHasNonWhitespace;
    private bool hasRetainedLine;
    private bool skipLineFeed;
    private bool finished;

    public NormalizedPooledStringBuilder(int initialCapacity = 256)
        : base(initialCapacity)
    {
    }

    public override void Append(char value)
    {
        if (skipLineFeed)
        {
            skipLineFeed = false;
            if (value == '\n')
            {
                return;
            }
        }

        if (value is '\r' or '\n')
        {
            FinishLine();
            skipLineFeed = value == '\r';
            return;
        }

        BeginLine();
        base.Append(value);
        lineHasNonWhitespace |= !char.IsWhiteSpace(value);
    }

    public override void Append(char value, int count)
    {
        for (var index = 0; index < count; index++)
        {
            Append(value);
        }
    }

    public override void Append(string? value)
    {
        if (value is { Length: > 0 })
        {
            Append(value, 0, value.Length);
        }
    }

    public override void Append(string value, int startIndex, int count)
    {
#if NET8_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(value);
        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(count, value.Length - startIndex);
#else
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }
        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        if (count < 0 || startIndex > value.Length - count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
#endif
        if (count == 0)
        {
            return;
        }

        var index = startIndex;
        var endIndex = startIndex + count;
        if (skipLineFeed)
        {
            skipLineFeed = false;
            if (value[index] == '\n')
            {
                index++;
            }
        }

        while (index < endIndex)
        {
            var segmentStart = index;
            while (index < endIndex && value[index] is not ('\r' or '\n'))
            {
                index++;
            }

            if (index > segmentStart)
            {
                BeginLine();
                base.Append(value, segmentStart, index - segmentStart);
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

            if (index == endIndex)
            {
                break;
            }

            var newline = value[index++];
            FinishLine();
            if (newline == '\r')
            {
                if (index < endIndex && value[index] == '\n')
                {
                    index++;
                }
                else if (index == endIndex)
                {
                    skipLineFeed = true;
                }
            }
        }
    }

    public override string ToString()
    {
        if (!finished)
        {
            FinishLine();
            finished = true;
        }

        return base.ToString();
    }

    private void BeginLine()
    {
        if (lineStarted)
        {
            return;
        }

        lineStart = Length;
        if (hasRetainedLine)
        {
            base.Append('\n');
        }
        lineStarted = true;
    }

    private void FinishLine()
    {
        BeginLine();
        if (Length > lineStart + (hasRetainedLine ? 1 : 0) && !lineHasNonWhitespace)
        {
            Truncate(lineStart);
        }
        else
        {
            hasRetainedLine = true;
        }

        lineStarted = false;
        lineHasNonWhitespace = false;
    }
}
