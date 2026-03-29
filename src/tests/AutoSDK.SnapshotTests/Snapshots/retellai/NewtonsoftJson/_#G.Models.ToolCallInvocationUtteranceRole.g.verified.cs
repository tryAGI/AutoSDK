//HintName: G.Models.ToolCallInvocationUtteranceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is a tool call invocation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallInvocationUtteranceRole
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
    public static class ToolCallInvocationUtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallInvocationUtteranceRole value)
        {
            return value switch
            {
                ToolCallInvocationUtteranceRole.ToolCallInvocation => "tool_call_invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallInvocationUtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_invocation" => ToolCallInvocationUtteranceRole.ToolCallInvocation,
                _ => null,
            };
        }
    }
}