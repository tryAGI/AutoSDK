using System.Buffers;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace AutoSDK.Generation;

internal class PooledStringBuilder : IDisposable
{
    private char[] buffer;
    private int length;

    public PooledStringBuilder(int initialCapacity = 256)
    {
        buffer = ArrayPool<char>.Shared.Rent(Math.Max(initialCapacity, 1));
    }

    public int Length => length;

    public virtual void Append(char value)
    {
        EnsureCapacity(1);
        buffer[length++] = value;
    }

    public virtual void Append(char value, int count)
    {
        if (count <= 0)
        {
            return;
        }

        EnsureCapacity(count);
        var end = length + count;
        while (length < end)
        {
            buffer[length++] = value;
        }
    }

    public virtual void Append(string? value)
    {
        if (value is not { Length: > 0 })
        {
            return;
        }

        EnsureCapacity(value.Length);
        value.CopyTo(0, buffer, length, value.Length);
        length += value.Length;
    }

    public void Append(
        [InterpolatedStringHandlerArgument("")] ref PooledStringBuilderInterpolatedStringHandler handler)
    {
        _ = length;
    }

    public virtual void Append(string value, int startIndex, int count)
    {
        if (count == 0)
        {
            return;
        }

        EnsureCapacity(count);
        value.CopyTo(startIndex, buffer, length, count);
        length += count;
    }

    public override string ToString()
    {
        return length == 0
            ? string.Empty
            : new string(buffer, 0, length);
    }

    public void Truncate(int newLength)
    {
        if ((uint)newLength > (uint)length)
        {
            throw new ArgumentOutOfRangeException(nameof(newLength));
        }

        length = newLength;
    }

    public void Dispose()
    {
        var rented = buffer;
        buffer = [];
        length = 0;
        if (rented.Length > 0)
        {
            ArrayPool<char>.Shared.Return(rented);
        }
    }

    private void EnsureCapacity(int additionalLength)
    {
        var requiredLength = checked(length + additionalLength);
        if (requiredLength <= buffer.Length)
        {
            return;
        }

        var newBuffer = ArrayPool<char>.Shared.Rent(Math.Max(requiredLength, checked(buffer.Length * 2)));
        Array.Copy(buffer, newBuffer, length);
        ArrayPool<char>.Shared.Return(buffer);
        buffer = newBuffer;
    }
}

[InterpolatedStringHandler]
internal readonly ref struct PooledStringBuilderInterpolatedStringHandler
{
    private readonly PooledStringBuilder builder;

    public PooledStringBuilderInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        PooledStringBuilder builder)
    {
        this.builder = builder;
    }

    public void AppendLiteral(string value)
    {
        builder.Append(value);
    }

    public void AppendFormatted(string? value)
    {
        builder.Append(value);
    }

    public void AppendFormatted(Sources.HookInvocation value)
    {
        value.AppendTo(builder);
    }

    public void AppendFormatted<T>(T value)
    {
        builder.Append(value?.ToString());
    }

    public void AppendFormatted<T>(T value, string? format)
    {
        builder.Append(value is IFormattable formattable
            ? formattable.ToString(format, CultureInfo.CurrentCulture)
            : value?.ToString());
    }
}
