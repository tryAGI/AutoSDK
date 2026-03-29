//HintName: G.Models.GhlToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "ghl" for GHL tool.
    /// </summary>
    public enum GhlToolProviderDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        Ghl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GhlToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GhlToolProviderDetailsType value)
        {
            return value switch
            {
                GhlToolProviderDetailsType.Ghl => "ghl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GhlToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "ghl" => GhlToolProviderDetailsType.Ghl,
                _ => null,
            };
        }
    }
}