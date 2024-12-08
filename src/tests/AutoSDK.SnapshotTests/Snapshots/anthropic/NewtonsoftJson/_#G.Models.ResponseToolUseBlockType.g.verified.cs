//HintName: G.Models.ResponseToolUseBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: tool_use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_use")]
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseToolUseBlockType value)
        {
            return value switch
            {
                ResponseToolUseBlockType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_use" => ResponseToolUseBlockType.ToolUse,
                _ => null,
            };
        }
    }
}