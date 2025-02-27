//HintName: G.Models.BetaInputContentBlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaInputContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document")]
        Document,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="redacted_thinking")]
        RedactedThinking,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thinking")]
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_result")]
        ToolResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_use")]
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