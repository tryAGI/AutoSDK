//HintName: G.Models.ClassifierDetailedJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassifierDetailedJobOutStatus
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
    public static class ClassifierDetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierDetailedJobOutStatus value)
        {
            return value switch
            {
                ClassifierDetailedJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                ClassifierDetailedJobOutStatus.Cancelled => "CANCELLED",
                ClassifierDetailedJobOutStatus.Failed => "FAILED",
                ClassifierDetailedJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                ClassifierDetailedJobOutStatus.Queued => "QUEUED",
                ClassifierDetailedJobOutStatus.Running => "RUNNING",
                ClassifierDetailedJobOutStatus.Started => "STARTED",
                ClassifierDetailedJobOutStatus.Success => "SUCCESS",
                ClassifierDetailedJobOutStatus.Validated => "VALIDATED",
                ClassifierDetailedJobOutStatus.Validating => "VALIDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierDetailedJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLATION_REQUESTED" => ClassifierDetailedJobOutStatus.CancellationRequested,
                "CANCELLED" => ClassifierDetailedJobOutStatus.Cancelled,
                "FAILED" => ClassifierDetailedJobOutStatus.Failed,
                "FAILED_VALIDATION" => ClassifierDetailedJobOutStatus.FailedValidation,
                "QUEUED" => ClassifierDetailedJobOutStatus.Queued,
                "RUNNING" => ClassifierDetailedJobOutStatus.Running,
                "STARTED" => ClassifierDetailedJobOutStatus.Started,
                "SUCCESS" => ClassifierDetailedJobOutStatus.Success,
                "VALIDATED" => ClassifierDetailedJobOutStatus.Validated,
                "VALIDATING" => ClassifierDetailedJobOutStatus.Validating,
                _ => null,
            };
        }
    }
}