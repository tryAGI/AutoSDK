//HintName: G.Models.ChatCompletionToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call
    /// </summary>
    public enum ChatCompletionToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionToolCallType value)
        {
            return value switch
            {
                ChatCompletionToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionToolCallType.Function,
                _ => null,
            };
        }
    }
}