//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDeltaStepDetailsToolCallsCodeObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
    }

    public static class RunStepDeltaStepDetailsToolCallsCodeObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsCodeObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsCodeObjectType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsCodeObjectType ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => RunStepDeltaStepDetailsToolCallsCodeObjectType.CodeInterpreter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsCodeObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaStepDetailsToolCallsCodeObjectType.CodeInterpreter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}