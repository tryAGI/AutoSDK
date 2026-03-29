//HintName: G.Models.ChatRequestCacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestCacheControlTtl
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
    public static class ChatRequestCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCacheControlTtl value)
        {
            return value switch
            {
                ChatRequestCacheControlTtl.x1h => "1h",
                ChatRequestCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatRequestCacheControlTtl.x1h,
                "5m" => ChatRequestCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}