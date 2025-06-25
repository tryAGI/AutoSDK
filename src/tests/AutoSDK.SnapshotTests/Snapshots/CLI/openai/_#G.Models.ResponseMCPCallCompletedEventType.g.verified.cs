//HintName: G.Models.ResponseMCPCallCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call.completed'.
    /// </summary>
    public enum ResponseMCPCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPCallCompletedEventType value)
        {
            return value switch
            {
                ResponseMCPCallCompletedEventType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.completed" => ResponseMCPCallCompletedEventType.ResponseMcpCallCompleted,
                _ => null,
            };
        }
    }
}