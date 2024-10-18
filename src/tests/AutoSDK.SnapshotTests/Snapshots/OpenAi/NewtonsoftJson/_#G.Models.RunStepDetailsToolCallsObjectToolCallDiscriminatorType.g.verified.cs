//HintName: G.Models.RunStepDetailsToolCallsObjectToolCallDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDetailsToolCallsObjectToolCallDiscriminatorType
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
    public static class RunStepDetailsToolCallsObjectToolCallDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDetailsToolCallsObjectToolCallDiscriminatorType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsObjectToolCallDiscriminatorType.CodeInterpreter => "code_interpreter",
                RunStepDetailsToolCallsObjectToolCallDiscriminatorType.FileSearch => "file_search",
                RunStepDetailsToolCallsObjectToolCallDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDetailsToolCallsObjectToolCallDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => RunStepDetailsToolCallsObjectToolCallDiscriminatorType.CodeInterpreter,
                "file_search" => RunStepDetailsToolCallsObjectToolCallDiscriminatorType.FileSearch,
                "function" => RunStepDetailsToolCallsObjectToolCallDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}