//HintName: G.Models.RunStepDeltaStepDetailsToolCallsFunctionObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call. This is always going to be `function` for this type of tool call.
    /// </summary>
    public enum RunStepDeltaStepDetailsToolCallsFunctionObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    public static class RunStepDeltaStepDetailsToolCallsFunctionObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsFunctionObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsFunctionObjectType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsFunctionObjectType ToEnum(string value)
        {
            return value switch
            {
                "function" => RunStepDeltaStepDetailsToolCallsFunctionObjectType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsFunctionObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaStepDetailsToolCallsFunctionObjectType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}