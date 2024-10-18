//HintName: G.Models.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.CodeInterpreter => "code_interpreter",
                RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.FileSearch => "file_search",
                RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.CodeInterpreter,
                "file_search" => RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.FileSearch,
                "function" => RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}