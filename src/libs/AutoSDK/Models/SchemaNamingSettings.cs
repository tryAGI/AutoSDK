namespace AutoSDK.Models;

public readonly struct SchemaNamingSettings : IEquatable<SchemaNamingSettings>
{
    public SchemaNamingSettings(string clsCompliantEnumPrefix, bool useExtensionNaming)
    {
        ClsCompliantEnumPrefix = clsCompliantEnumPrefix;
        UseExtensionNaming = useExtensionNaming;
    }

    public string ClsCompliantEnumPrefix { get; }
    public bool UseExtensionNaming { get; }

    public bool Equals(SchemaNamingSettings other)
    {
        return string.Equals(ClsCompliantEnumPrefix, other.ClsCompliantEnumPrefix, StringComparison.Ordinal) &&
               UseExtensionNaming == other.UseExtensionNaming;
    }

    public override bool Equals(object? obj)
    {
        return obj is SchemaNamingSettings other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = StringComparer.Ordinal.GetHashCode(ClsCompliantEnumPrefix ?? string.Empty);
            hashCode = (hashCode * 397) ^ UseExtensionNaming.GetHashCode();
            return hashCode;
        }
    }

    public static bool operator ==(SchemaNamingSettings left, SchemaNamingSettings right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(SchemaNamingSettings left, SchemaNamingSettings right)
    {
        return !left.Equals(right);
    }
}
