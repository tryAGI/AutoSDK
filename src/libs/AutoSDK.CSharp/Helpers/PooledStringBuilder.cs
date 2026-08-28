using System.Buffers;

namespace AutoSDK.Generation;

internal sealed class PooledStringBuilder : IDisposable
{
    private char[] buffer;
    private int length;

    public PooledStringBuilder(int initialCapacity = 256)
    {
        buffer = ArrayPool<char>.Shared.Rent(Math.Max(initialCapacity, 1));
    }

    public int Length => length;

    public void Append(char value)
    {
        EnsureCapacity(1);
        buffer[length++] = value;
    }

    public void Append(string? value)
    {
        if (value is not { Length: > 0 })
        {
            return;
        }

        EnsureCapacity(value.Length);
        value.CopyTo(0, buffer, length, value.Length);
        length += value.Length;
    }

    public void Append(string value, int startIndex, int count)
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
