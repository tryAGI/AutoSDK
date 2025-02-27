//HintName: G.Models.URLImageSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum URLImageSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class URLImageSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this URLImageSourceType value)
        {
            return value switch
            {
                URLImageSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static URLImageSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => URLImageSourceType.Url,
                _ => null,
            };
        }
    }
}