//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl
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
    public static class MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl.x1h => "1h",
                MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl.x1h,
                "5m" => MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}