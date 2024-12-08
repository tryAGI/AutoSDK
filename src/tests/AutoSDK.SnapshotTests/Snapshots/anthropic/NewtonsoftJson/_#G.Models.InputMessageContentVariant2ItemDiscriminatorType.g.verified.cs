//HintName: G.Models.InputMessageContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputMessageContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
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
    public static class InputMessageContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                InputMessageContentVariant2ItemDiscriminatorType.Image => "image",
                InputMessageContentVariant2ItemDiscriminatorType.Text => "text",
                InputMessageContentVariant2ItemDiscriminatorType.ToolResult => "tool_result",
                InputMessageContentVariant2ItemDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => InputMessageContentVariant2ItemDiscriminatorType.Image,
                "text" => InputMessageContentVariant2ItemDiscriminatorType.Text,
                "tool_result" => InputMessageContentVariant2ItemDiscriminatorType.ToolResult,
                "tool_use" => InputMessageContentVariant2ItemDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}