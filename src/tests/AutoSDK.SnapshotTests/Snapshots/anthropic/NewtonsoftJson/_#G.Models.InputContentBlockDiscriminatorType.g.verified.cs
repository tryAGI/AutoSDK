//HintName: G.Models.InputContentBlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputContentBlockDiscriminatorType
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
    public static class InputContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputContentBlockDiscriminatorType value)
        {
            return value switch
            {
                InputContentBlockDiscriminatorType.Document => "document",
                InputContentBlockDiscriminatorType.Image => "image",
                InputContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                InputContentBlockDiscriminatorType.Text => "text",
                InputContentBlockDiscriminatorType.Thinking => "thinking",
                InputContentBlockDiscriminatorType.ToolResult => "tool_result",
                InputContentBlockDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => InputContentBlockDiscriminatorType.Document,
                "image" => InputContentBlockDiscriminatorType.Image,
                "redacted_thinking" => InputContentBlockDiscriminatorType.RedactedThinking,
                "text" => InputContentBlockDiscriminatorType.Text,
                "thinking" => InputContentBlockDiscriminatorType.Thinking,
                "tool_result" => InputContentBlockDiscriminatorType.ToolResult,
                "tool_use" => InputContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}