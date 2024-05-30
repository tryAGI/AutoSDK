//HintName: G.Models.RunStepDetailsToolCallsObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `tool_calls`.
    /// </summary>
    public enum RunStepDetailsToolCallsObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDetailsToolCallsObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDetailsToolCallsObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsObjectType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDetailsToolCallsObjectType ToEnum(string value)
        {
            return value switch
            {
                "tool_calls" => RunStepDetailsToolCallsObjectType.ToolCalls,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}