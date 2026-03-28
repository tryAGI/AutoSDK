namespace AutoSDK.Models;

public readonly struct EnumNamingSettings : IEquatable<EnumNamingSettings>
{
    public EnumNamingSettings(string clsCompliantEnumPrefix)
    {
        ClsCompliantEnumPrefix = clsCompliantEnumPrefix;
    }

    public string ClsCompliantEnumPrefix { get; }

    public bool Equals(EnumNamingSettings other)
    {
        return string.Equals(ClsCompliantEnumPrefix, other.ClsCompliantEnumPrefix, StringComparison.Ordinal);
    }

    public override bool Equals(object? obj)
    {
        return obj is EnumNamingSettings other && Equals(other);
    }

    public override int GetHashCode()
    {
        return StringComparer.Ordinal.GetHashCode(ClsCompliantEnumPrefix ?? string.Empty);
    }

    public static bool operator ==(EnumNamingSettings left, EnumNamingSettings right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(EnumNamingSettings left, EnumNamingSettings right)
    {
        return !left.Equals(right);
    }
}
