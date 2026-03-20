//HintName: G.Models.ResponseMcpCallFailedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseMcpCallFailedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMcpCallFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMcpCallFailedEventType value)
        {
            return value switch
            {
                ResponseMcpCallFailedEventType.ResponseMcpCallFailed => "response.mcp_call.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMcpCallFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.failed" => ResponseMcpCallFailedEventType.ResponseMcpCallFailed,
                _ => null,
            };
        }
    }
}