//HintName: G.Models.BetaInputContentBlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaInputContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Image,
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
        ToolResult,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaInputContentBlockDiscriminatorType.Document => "document",
                BetaInputContentBlockDiscriminatorType.Image => "image",
                BetaInputContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                BetaInputContentBlockDiscriminatorType.Text => "text",
                BetaInputContentBlockDiscriminatorType.Thinking => "thinking",
                BetaInputContentBlockDiscriminatorType.ToolResult => "tool_result",
                BetaInputContentBlockDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BetaInputContentBlockDiscriminatorType.Document,
                "image" => BetaInputContentBlockDiscriminatorType.Image,
                "redacted_thinking" => BetaInputContentBlockDiscriminatorType.RedactedThinking,
                "text" => BetaInputContentBlockDiscriminatorType.Text,
                "thinking" => BetaInputContentBlockDiscriminatorType.Thinking,
                "tool_result" => BetaInputContentBlockDiscriminatorType.ToolResult,
                "tool_use" => BetaInputContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}