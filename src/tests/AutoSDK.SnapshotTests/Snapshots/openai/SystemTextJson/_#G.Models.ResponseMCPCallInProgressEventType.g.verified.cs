//HintName: G.Models.ResponseMCPCallInProgressEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call.in_progress'.
    /// </summary>
    public enum ResponseMCPCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPCallInProgressEventType value)
        {
            return value switch
            {
                ResponseMCPCallInProgressEventType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.in_progress" => ResponseMCPCallInProgressEventType.ResponseMcpCallInProgress,
                _ => null,
            };
        }
    }
}