//HintName: G.Models.ResponseMCPCallArgumentsDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call.arguments_done'.
    /// </summary>
    public enum ResponseMCPCallArgumentsDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPCallArgumentsDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPCallArgumentsDoneEventType value)
        {
            return value switch
            {
                ResponseMCPCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone => "response.mcp_call.arguments_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPCallArgumentsDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.arguments_done" => ResponseMCPCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone,
                _ => null,
            };
        }
    }
}