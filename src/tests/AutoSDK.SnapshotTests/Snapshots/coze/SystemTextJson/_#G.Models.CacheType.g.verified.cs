//HintName: G.Models.CacheType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CacheType
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Prefix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CacheTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CacheType value)
        {
            return value switch
            {
                CacheType.Closed => "closed",
                CacheType.Prefix => "prefix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CacheType? ToEnum(string value)
        {
            return value switch
            {
                "closed" => CacheType.Closed,
                "prefix" => CacheType.Prefix,
                _ => null,
            };
        }
    }
}