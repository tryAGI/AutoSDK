//HintName: G.Models.RunStepDetailsToolCallsFunctionObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call. This is always going to be `function` for this type of tool call.
    /// </summary>
    public enum RunStepDetailsToolCallsFunctionObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    public static class RunStepDetailsToolCallsFunctionObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDetailsToolCallsFunctionObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsFunctionObjectType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsFunctionObjectType ToEnum(string value)
        {
            return value switch
            {
                "function" => RunStepDetailsToolCallsFunctionObjectType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsFunctionObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDetailsToolCallsFunctionObjectType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}