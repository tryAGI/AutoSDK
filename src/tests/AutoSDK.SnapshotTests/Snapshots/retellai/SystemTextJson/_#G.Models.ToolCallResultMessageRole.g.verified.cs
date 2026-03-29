//HintName: G.Models.ToolCallResultMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the result of a tool call.
    /// </summary>
    public enum ToolCallResultMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCallResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallResultMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallResultMessageRole value)
        {
            return value switch
            {
                ToolCallResultMessageRole.ToolCallResult => "tool_call_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallResultMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_result" => ToolCallResultMessageRole.ToolCallResult,
                _ => null,
            };
        }
    }
}