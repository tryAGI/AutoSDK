//HintName: G.Models.InvalidToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InvalidToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_tool_call")]
        InvalidToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvalidToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvalidToolCallType value)
        {
            return value switch
            {
                InvalidToolCallType.InvalidToolCall => "invalid_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvalidToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_call" => InvalidToolCallType.InvalidToolCall,
                _ => null,
            };
        }
    }
}