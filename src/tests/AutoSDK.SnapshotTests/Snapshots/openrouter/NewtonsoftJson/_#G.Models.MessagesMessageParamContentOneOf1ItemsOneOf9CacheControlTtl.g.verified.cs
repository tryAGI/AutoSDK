//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1h")]
        x1h,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5m")]
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl.x1h => "1h",
                MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl.x1h,
                "5m" => MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}