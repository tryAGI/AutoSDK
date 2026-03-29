//HintName: G.Models.ChatCompletionMessageContentPartRedactedThinkingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part.
    /// </summary>
    public enum ChatCompletionMessageContentPartRedactedThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageContentPartRedactedThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageContentPartRedactedThinkingType value)
        {
            return value switch
            {
                ChatCompletionMessageContentPartRedactedThinkingType.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageContentPartRedactedThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => ChatCompletionMessageContentPartRedactedThinkingType.RedactedThinking,
                _ => null,
            };
        }
    }
}