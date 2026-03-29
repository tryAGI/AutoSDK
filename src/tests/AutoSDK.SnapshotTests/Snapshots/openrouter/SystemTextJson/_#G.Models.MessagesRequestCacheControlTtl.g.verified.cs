//HintName: G.Models.MessagesRequestCacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestCacheControlTtl
    {
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestCacheControlTtl value)
        {
            return value switch
            {
                MessagesRequestCacheControlTtl.x1h => "1h",
                MessagesRequestCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => MessagesRequestCacheControlTtl.x1h,
                "5m" => MessagesRequestCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}