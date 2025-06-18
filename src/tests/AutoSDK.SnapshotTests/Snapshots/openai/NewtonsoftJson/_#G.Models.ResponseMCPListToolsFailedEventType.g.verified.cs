//HintName: G.Models.ResponseMCPListToolsFailedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_list_tools.failed'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseMCPListToolsFailedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.mcp_list_tools.failed")]
        ResponseMcpListToolsFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPListToolsFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPListToolsFailedEventType value)
        {
            return value switch
            {
                ResponseMCPListToolsFailedEventType.ResponseMcpListToolsFailed => "response.mcp_list_tools.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPListToolsFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.failed" => ResponseMCPListToolsFailedEventType.ResponseMcpListToolsFailed,
                _ => null,
            };
        }
    }
}