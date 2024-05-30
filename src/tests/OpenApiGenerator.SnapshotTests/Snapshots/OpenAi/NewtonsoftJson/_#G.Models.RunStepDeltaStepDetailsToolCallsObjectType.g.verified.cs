//HintName: G.Models.RunStepDeltaStepDetailsToolCallsObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `tool_calls`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDeltaStepDetailsToolCallsObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
        ToolCalls,
    }

    public static class RunStepDeltaStepDetailsToolCallsObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsObjectType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsObjectType ToEnum(string value)
        {
            return value switch
            {
                "tool_calls" => RunStepDeltaStepDetailsToolCallsObjectType.ToolCalls,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaStepDetailsToolCallsObjectType.ToolCalls,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}