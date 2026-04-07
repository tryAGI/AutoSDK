namespace AutoSDK.Models;

public readonly struct EnumNamingSettings : IEquatable<EnumNamingSettings>
{
    public EnumNamingSettings(
        string clsCompliantEnumPrefix,
        IdentifierCharacterSet identifierCharacterSet = IdentifierCharacterSet.UnicodeLetters)
    {
        ClsCompliantEnumPrefix = clsCompliantEnumPrefix;
        IdentifierCharacterSet = identifierCharacterSet;
    }

    public string ClsCompliantEnumPrefix { get; }
    public IdentifierCharacterSet IdentifierCharacterSet { get; }

    public bool Equals(EnumNamingSettings other)
    {
        return string.Equals(ClsCompliantEnumPrefix, other.ClsCompliantEnumPrefix, StringComparison.Ordinal) &&
               IdentifierCharacterSet == other.IdentifierCharacterSet;
    }

    public override bool Equals(object? obj)
    {
        return obj is EnumNamingSettings other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = StringComparer.Ordinal.GetHashCode(ClsCompliantEnumPrefix ?? string.Empty);
            hashCode = (hashCode * 397) ^ (int)IdentifierCharacterSet;
            return hashCode;
        }
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
