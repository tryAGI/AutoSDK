//HintName: G.Models.ClassifierJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassifierJobOutStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLATION_REQUESTED")]
        CancellationRequested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED_VALIDATION")]
        FailedValidation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATED")]
        Validated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATING")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutStatus value)
        {
            return value switch
            {
                ClassifierJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                ClassifierJobOutStatus.Cancelled => "CANCELLED",
                ClassifierJobOutStatus.Failed => "FAILED",
                ClassifierJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                ClassifierJobOutStatus.Queued => "QUEUED",
                ClassifierJobOutStatus.Running => "RUNNING",
                ClassifierJobOutStatus.Started => "STARTED",
                ClassifierJobOutStatus.Success => "SUCCESS",
                ClassifierJobOutStatus.Validated => "VALIDATED",
                ClassifierJobOutStatus.Validating => "VALIDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLATION_REQUESTED" => ClassifierJobOutStatus.CancellationRequested,
                "CANCELLED" => ClassifierJobOutStatus.Cancelled,
                "FAILED" => ClassifierJobOutStatus.Failed,
                "FAILED_VALIDATION" => ClassifierJobOutStatus.FailedValidation,
                "QUEUED" => ClassifierJobOutStatus.Queued,
                "RUNNING" => ClassifierJobOutStatus.Running,
                "STARTED" => ClassifierJobOutStatus.Started,
                "SUCCESS" => ClassifierJobOutStatus.Success,
                "VALIDATED" => ClassifierJobOutStatus.Validated,
                "VALIDATING" => ClassifierJobOutStatus.Validating,
                _ => null,
            };
        }
    }
}