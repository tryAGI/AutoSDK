//HintName: G.Models.MessagesRequestToolsItemsOneOf1CacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf1CacheControlTtl
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
    public static class MessagesRequestToolsItemsOneOf1CacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf1CacheControlTtl value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf1CacheControlTtl.x1h => "1h",
                MessagesRequestToolsItemsOneOf1CacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf1CacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => MessagesRequestToolsItemsOneOf1CacheControlTtl.x1h,
                "5m" => MessagesRequestToolsItemsOneOf1CacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}