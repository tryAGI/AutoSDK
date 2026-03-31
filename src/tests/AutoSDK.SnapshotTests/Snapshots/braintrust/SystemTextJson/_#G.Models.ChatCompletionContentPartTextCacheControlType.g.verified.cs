//HintName: G.Models.ChatCompletionContentPartTextCacheControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionContentPartTextCacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartTextCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartTextCacheControlType value)
        {
            return value switch
            {
                ChatCompletionContentPartTextCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartTextCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => ChatCompletionContentPartTextCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}