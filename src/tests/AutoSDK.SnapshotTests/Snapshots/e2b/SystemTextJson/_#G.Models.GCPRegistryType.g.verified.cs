//HintName: G.Models.GCPRegistryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of registry authentication
    /// </summary>
    public enum GCPRegistryType
    {
        /// <summary>
        /// 
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GCPRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GCPRegistryType value)
        {
            return value switch
            {
                GCPRegistryType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GCPRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "gcp" => GCPRegistryType.Gcp,
                _ => null,
            };
        }
    }
}