//HintName: G.Models.ChatRequestCacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestCacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCacheControlType value)
        {
            return value switch
            {
                ChatRequestCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => ChatRequestCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}