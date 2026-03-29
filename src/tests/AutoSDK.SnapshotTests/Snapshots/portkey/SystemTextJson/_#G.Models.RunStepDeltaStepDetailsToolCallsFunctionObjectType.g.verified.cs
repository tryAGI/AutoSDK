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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDeltaStepDetailsToolCallsFunctionObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsFunctionObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsFunctionObjectType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaStepDetailsToolCallsFunctionObjectType? ToEnum(string value)
        {
            return value switch
            {
                "function" => RunStepDeltaStepDetailsToolCallsFunctionObjectType.Function,
                _ => null,
            };
        }
    }
}