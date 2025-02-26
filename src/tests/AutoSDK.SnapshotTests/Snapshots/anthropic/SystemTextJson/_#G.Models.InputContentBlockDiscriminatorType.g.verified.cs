//HintName: G.Models.InputContentBlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputContentBlockDiscriminatorType
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
        Text,
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
                InputContentBlockDiscriminatorType.Text => "text",
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
                "text" => InputContentBlockDiscriminatorType.Text,
                "tool_result" => InputContentBlockDiscriminatorType.ToolResult,
                "tool_use" => InputContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}