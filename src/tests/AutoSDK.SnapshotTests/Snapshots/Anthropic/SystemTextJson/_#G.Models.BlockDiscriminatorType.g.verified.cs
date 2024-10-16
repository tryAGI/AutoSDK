//HintName: G.Models.BlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlockDiscriminatorType value)
        {
            return value switch
            {
                BlockDiscriminatorType.Text => "text",
                BlockDiscriminatorType.Image => "image",
                BlockDiscriminatorType.ToolUse => "tool_use",
                BlockDiscriminatorType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BlockDiscriminatorType.Text,
                "image" => BlockDiscriminatorType.Image,
                "tool_use" => BlockDiscriminatorType.ToolUse,
                "tool_result" => BlockDiscriminatorType.ToolResult,
                _ => null,
            };
        }
    }
}