//HintName: G.Models.ClientMessageToolCallsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "tool-calls" is sent to call a tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageToolCallsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-calls")]
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageToolCallsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageToolCallsType value)
        {
            return value switch
            {
                ClientMessageToolCallsType.ToolCalls => "tool-calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageToolCallsType? ToEnum(string value)
        {
            return value switch
            {
                "tool-calls" => ClientMessageToolCallsType.ToolCalls,
                _ => null,
            };
        }
    }
}