//HintName: G.Models.GeneralRegistryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of registry authentication
    /// </summary>
    public enum GeneralRegistryType
    {
        /// <summary>
        /// 
        /// </summary>
        Registry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneralRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneralRegistryType value)
        {
            return value switch
            {
                GeneralRegistryType.Registry => "registry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneralRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "registry" => GeneralRegistryType.Registry,
                _ => null,
            };
        }
    }
}