//HintName: G.Models.RunStepDetailsToolCallsCodeObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
    /// </summary>
    public enum RunStepDetailsToolCallsCodeObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
    }

    public static class RunStepDetailsToolCallsCodeObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDetailsToolCallsCodeObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsCodeObjectType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsCodeObjectType ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => RunStepDetailsToolCallsCodeObjectType.CodeInterpreter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsCodeObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDetailsToolCallsCodeObjectType.CodeInterpreter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}