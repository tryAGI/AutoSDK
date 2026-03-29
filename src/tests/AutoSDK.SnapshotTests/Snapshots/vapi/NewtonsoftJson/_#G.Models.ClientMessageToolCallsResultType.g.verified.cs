//HintName: G.Models.ClientMessageToolCallsResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "tool-calls-result" is sent to forward the result of a tool call to the client.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageToolCallsResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-calls-result")]
        ToolCallsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageToolCallsResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageToolCallsResultType value)
        {
            return value switch
            {
                ClientMessageToolCallsResultType.ToolCallsResult => "tool-calls-result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageToolCallsResultType? ToEnum(string value)
        {
            return value switch
            {
                "tool-calls-result" => ClientMessageToolCallsResultType.ToolCallsResult,
                _ => null,
            };
        }
    }
}