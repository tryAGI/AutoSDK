//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestSystemOneOf1ItemsCacheControlTtl
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
    public static class MessagesRequestSystemOneOf1ItemsCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestSystemOneOf1ItemsCacheControlTtl value)
        {
            return value switch
            {
                MessagesRequestSystemOneOf1ItemsCacheControlTtl.x1h => "1h",
                MessagesRequestSystemOneOf1ItemsCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestSystemOneOf1ItemsCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => MessagesRequestSystemOneOf1ItemsCacheControlTtl.x1h,
                "5m" => MessagesRequestSystemOneOf1ItemsCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}