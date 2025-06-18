//HintName: G.Models.ResponseMCPListToolsCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_list_tools.completed'.
    /// </summary>
    public enum ResponseMCPListToolsCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpListToolsCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPListToolsCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPListToolsCompletedEventType value)
        {
            return value switch
            {
                ResponseMCPListToolsCompletedEventType.ResponseMcpListToolsCompleted => "response.mcp_list_tools.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPListToolsCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.completed" => ResponseMCPListToolsCompletedEventType.ResponseMcpListToolsCompleted,
                _ => null,
            };
        }
    }
}