//HintName: G.Models.MessagesRequestToolsItemsOneOf0CacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf0CacheControlTtl
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
    public static class MessagesRequestToolsItemsOneOf0CacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf0CacheControlTtl value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf0CacheControlTtl.x1h => "1h",
                MessagesRequestToolsItemsOneOf0CacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf0CacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => MessagesRequestToolsItemsOneOf0CacheControlTtl.x1h,
                "5m" => MessagesRequestToolsItemsOneOf0CacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}