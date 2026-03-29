//HintName: G.Models.ToolCallResultUtteranceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the result of a tool call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallResultUtteranceRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_call_result")]
        ToolCallResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallResultUtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallResultUtteranceRole value)
        {
            return value switch
            {
                ToolCallResultUtteranceRole.ToolCallResult => "tool_call_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallResultUtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_result" => ToolCallResultUtteranceRole.ToolCallResult,
                _ => null,
            };
        }
    }
}