//HintName: G.Models.RunStepDetailsToolCallsObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `tool_calls`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDetailsToolCallsObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
        ToolCalls,
    }

    public static class RunStepDetailsToolCallsObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDetailsToolCallsObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsObjectType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsObjectType ToEnum(string value)
        {
            return value switch
            {
                "tool_calls" => RunStepDetailsToolCallsObjectType.ToolCalls,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDetailsToolCallsObjectType.ToolCalls,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}