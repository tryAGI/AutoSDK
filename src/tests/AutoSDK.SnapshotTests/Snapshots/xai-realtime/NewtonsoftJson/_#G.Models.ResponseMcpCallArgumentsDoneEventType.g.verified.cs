//HintName: G.Models.ResponseMcpCallArgumentsDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseMcpCallArgumentsDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.mcp_call_arguments.done")]
        ResponseMcpCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMcpCallArgumentsDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMcpCallArgumentsDoneEventType value)
        {
            return value switch
            {
                ResponseMcpCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMcpCallArgumentsDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.done" => ResponseMcpCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone,
                _ => null,
            };
        }
    }
}