//HintName: G.Models.ExternalProxyConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of proxy. Always 'external' for this config.
    /// </summary>
    public enum ExternalProxyConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalProxyConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalProxyConfigType value)
        {
            return value switch
            {
                ExternalProxyConfigType.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalProxyConfigType? ToEnum(string value)
        {
            return value switch
            {
                "external" => ExternalProxyConfigType.External,
                _ => null,
            };
        }
    }
}