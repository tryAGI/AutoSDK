//HintName: G.Models.CodeExecutionResultOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. Outcome of the code execution.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeExecutionResultOutcome
    {
        /// <summary>
        /// Code execution ran for too long, and was cancelled. There may or may not be a partial `output` present.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OUTCOME_DEADLINE_EXCEEDED")]
        OutcomeDeadlineExceeded,
        /// <summary>
        /// Code execution failed. `output` contains the stderr and stdout, if any.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OUTCOME_FAILED")]
        OutcomeFailed,
        /// <summary>
        /// Code execution completed successfully. `output` contains the stdout, if any.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OUTCOME_OK")]
        OutcomeOk,
        /// <summary>
        /// Unspecified status. This value should not be used.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OUTCOME_UNSPECIFIED")]
        OutcomeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeExecutionResultOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionResultOutcome value)
        {
            return value switch
            {
                CodeExecutionResultOutcome.OutcomeDeadlineExceeded => "OUTCOME_DEADLINE_EXCEEDED",
                CodeExecutionResultOutcome.OutcomeFailed => "OUTCOME_FAILED",
                CodeExecutionResultOutcome.OutcomeOk => "OUTCOME_OK",
                CodeExecutionResultOutcome.OutcomeUnspecified => "OUTCOME_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionResultOutcome? ToEnum(string value)
        {
            return value switch
            {
                "OUTCOME_DEADLINE_EXCEEDED" => CodeExecutionResultOutcome.OutcomeDeadlineExceeded,
                "OUTCOME_FAILED" => CodeExecutionResultOutcome.OutcomeFailed,
                "OUTCOME_OK" => CodeExecutionResultOutcome.OutcomeOk,
                "OUTCOME_UNSPECIFIED" => CodeExecutionResultOutcome.OutcomeUnspecified,
                _ => null,
            };
        }
    }
}