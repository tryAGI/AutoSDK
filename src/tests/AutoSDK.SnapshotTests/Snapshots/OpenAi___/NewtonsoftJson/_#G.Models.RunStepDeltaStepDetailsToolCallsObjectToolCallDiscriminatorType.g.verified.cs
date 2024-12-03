//HintName: G.Models.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search")]
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
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