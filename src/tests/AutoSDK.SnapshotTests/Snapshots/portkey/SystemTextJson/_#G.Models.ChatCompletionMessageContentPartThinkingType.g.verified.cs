//HintName: G.Models.ChatCompletionMessageContentPartThinkingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part.
    /// </summary>
    public enum ChatCompletionMessageContentPartThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageContentPartThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageContentPartThinkingType value)
        {
            return value switch
            {
                ChatCompletionMessageContentPartThinkingType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageContentPartThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => ChatCompletionMessageContentPartThinkingType.Thinking,
                _ => null,
            };
        }
    }
}