//HintName: G.Models.BetaContentBlockStartEventContentBlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContentBlockStartEventContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        RedactedThinking,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockStartEventContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockStartEventContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                BetaContentBlockStartEventContentBlockDiscriminatorType.Text => "text",
                BetaContentBlockStartEventContentBlockDiscriminatorType.Thinking => "thinking",
                BetaContentBlockStartEventContentBlockDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockStartEventContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => BetaContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking,
                "text" => BetaContentBlockStartEventContentBlockDiscriminatorType.Text,
                "thinking" => BetaContentBlockStartEventContentBlockDiscriminatorType.Thinking,
                "tool_use" => BetaContentBlockStartEventContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}