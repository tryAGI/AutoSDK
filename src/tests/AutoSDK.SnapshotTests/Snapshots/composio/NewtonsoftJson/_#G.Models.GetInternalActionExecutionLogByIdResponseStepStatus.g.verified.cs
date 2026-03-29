//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetInternalActionExecutionLogByIdResponseStepStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
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