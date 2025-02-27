//HintName: G.Models.ResponseRedactedThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: redacted_thinking
    /// </summary>
    public enum ResponseRedactedThinkingBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRedactedThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRedactedThinkingBlockType value)
        {
            return value switch
            {
                ResponseRedactedThinkingBlockType.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRedactedThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => ResponseRedactedThinkingBlockType.RedactedThinking,
                _ => null,
            };
        }
    }
}