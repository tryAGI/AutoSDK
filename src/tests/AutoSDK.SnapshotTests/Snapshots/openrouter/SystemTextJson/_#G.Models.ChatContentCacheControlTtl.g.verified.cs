//HintName: G.Models.ChatContentCacheControlTtl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatContentCacheControlTtl
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
    public static class ChatContentCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentCacheControlTtl value)
        {
            return value switch
            {
                ChatContentCacheControlTtl.x1h => "1h",
                ChatContentCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatContentCacheControlTtl.x1h,
                "5m" => ChatContentCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}