//HintName: G.Models.ResponseMcpCallCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseMcpCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.mcp_call.completed")]
        ResponseMcpCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMcpCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMcpCallCompletedEventType value)
        {
            return value switch
            {
                ResponseMcpCallCompletedEventType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMcpCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.completed" => ResponseMcpCallCompletedEventType.ResponseMcpCallCompleted,
                _ => null,
            };
        }
    }
}