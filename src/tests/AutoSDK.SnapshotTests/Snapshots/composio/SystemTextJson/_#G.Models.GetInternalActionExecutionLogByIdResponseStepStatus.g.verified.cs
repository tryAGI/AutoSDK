//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetInternalActionExecutionLogByIdResponseStepStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetInternalActionExecutionLogByIdResponseStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInternalActionExecutionLogByIdResponseStepStatus value)
        {
            return value switch
            {
                GetInternalActionExecutionLogByIdResponseStepStatus.Error => "error",
                GetInternalActionExecutionLogByIdResponseStepStatus.Failure => "failure",
                GetInternalActionExecutionLogByIdResponseStepStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInternalActionExecutionLogByIdResponseStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetInternalActionExecutionLogByIdResponseStepStatus.Error,
                "failure" => GetInternalActionExecutionLogByIdResponseStepStatus.Failure,
                "success" => GetInternalActionExecutionLogByIdResponseStepStatus.Success,
                _ => null,
            };
        }
    }
}