//HintName: G.Models.ResponseMCPListToolsInProgressEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_list_tools.in_progress'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseMCPListToolsInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.mcp_list_tools.in_progress")]
        ResponseMcpListToolsInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPListToolsInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPListToolsInProgressEventType value)
        {
            return value switch
            {
                ResponseMCPListToolsInProgressEventType.ResponseMcpListToolsInProgress => "response.mcp_list_tools.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPListToolsInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.in_progress" => ResponseMCPListToolsInProgressEventType.ResponseMcpListToolsInProgress,
                _ => null,
            };
        }
    }
}