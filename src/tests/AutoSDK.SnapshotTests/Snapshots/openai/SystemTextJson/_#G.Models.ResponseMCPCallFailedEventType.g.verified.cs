//HintName: G.Models.ResponseMCPCallFailedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call.failed'.
    /// </summary>
    public enum ResponseMCPCallFailedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPCallFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPCallFailedEventType value)
        {
            return value switch
            {
                ResponseMCPCallFailedEventType.ResponseMcpCallFailed => "response.mcp_call.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPCallFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.failed" => ResponseMCPCallFailedEventType.ResponseMcpCallFailed,
                _ => null,
            };
        }
    }
}