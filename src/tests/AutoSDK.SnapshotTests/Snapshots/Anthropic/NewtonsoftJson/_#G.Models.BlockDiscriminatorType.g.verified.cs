//HintName: G.Models.BlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_use")]
        ToolUse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_result")]
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