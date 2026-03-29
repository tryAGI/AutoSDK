//HintName: G.Models.ServerMessageToolCallsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "tool-calls" is sent to call a tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageToolCallsType
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
    public static class ServerMessageToolCallsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageToolCallsType value)
        {
            return value switch
            {
                ServerMessageToolCallsType.ToolCalls => "tool-calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageToolCallsType? ToEnum(string value)
        {
            return value switch
            {
                "tool-calls" => ServerMessageToolCallsType.ToolCalls,
                _ => null,
            };
        }
    }
}