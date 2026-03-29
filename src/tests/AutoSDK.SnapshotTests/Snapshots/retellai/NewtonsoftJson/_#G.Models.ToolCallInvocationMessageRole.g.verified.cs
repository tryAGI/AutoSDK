//HintName: G.Models.ToolCallInvocationMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is a tool call invocation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallInvocationMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_call_invocation")]
        ToolCallInvocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallInvocationMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallInvocationMessageRole value)
        {
            return value switch
            {
                ToolCallInvocationMessageRole.ToolCallInvocation => "tool_call_invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallInvocationMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_invocation" => ToolCallInvocationMessageRole.ToolCallInvocation,
                _ => null,
            };
        }
    }
}