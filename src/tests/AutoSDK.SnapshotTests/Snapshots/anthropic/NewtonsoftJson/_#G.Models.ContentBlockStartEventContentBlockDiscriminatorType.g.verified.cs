//HintName: G.Models.ContentBlockStartEventContentBlockDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentBlockStartEventContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_use")]
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
                ContentBlockStartEventContentBlockDiscriminatorType.Text => "text",
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
                "text" => ContentBlockStartEventContentBlockDiscriminatorType.Text,
                "tool_use" => ContentBlockStartEventContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}