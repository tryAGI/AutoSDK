namespace AutoSDK.Helpers;

public static class BoxEtensions
{
    public static T Unbox<T>(this Box box)
    {
        return (T)box.Value;
    }
    public static Box Box<T>(this T tobox)
    {
        return new Box() { Value = tobox };
    }
}

/// <summary>
/// This class is used to box any value type or reference type into an object.
/// This is used to avoid generic type cycling in structs.
/// This is only here to support visual studio. Other dotnet build tools do not require this.
/// More information can be found here:
/// https://github.com/dotnet/runtime/issues/6924
/// </summary>
public struct Box : IEquatable<Box>
{
    private object _value;
    public object Value
    {
        get => _value;
        set => _value = value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }
        if (obj is Box other)
        {
            return ReferenceEquals(Value, other.Value);
        }
        return false;
    }

    bool IEquatable<Box>.Equals(Box other)
    {
        return this.Equals(other);
    }

    public override int GetHashCode()
    {
        return Value?.GetHashCode() ?? 0;
    }

    public static bool operator ==(Box left, Box right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Box left, Box right)
    {
        return !(left == right);
    }
}
