//HintName: G.Models.ContentBlockStartEventContentBlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentBlockStartEventContentBlockDiscriminatorType
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
    public static class ContentBlockStartEventContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockStartEventContentBlockDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                ContentBlockStartEventContentBlockDiscriminatorType.Text => "text",
                ContentBlockStartEventContentBlockDiscriminatorType.Thinking => "thinking",
                ContentBlockStartEventContentBlockDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockStartEventContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking,
                "text" => ContentBlockStartEventContentBlockDiscriminatorType.Text,
                "thinking" => ContentBlockStartEventContentBlockDiscriminatorType.Thinking,
                "tool_use" => ContentBlockStartEventContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}