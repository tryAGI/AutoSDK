//HintName: G.Models.CompletionJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the fine-tuning job.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionJobOutStatus
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
    public static class CompletionJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionJobOutStatus value)
        {
            return value switch
            {
                CompletionJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                CompletionJobOutStatus.Cancelled => "CANCELLED",
                CompletionJobOutStatus.Failed => "FAILED",
                CompletionJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                CompletionJobOutStatus.Queued => "QUEUED",
                CompletionJobOutStatus.Running => "RUNNING",
                CompletionJobOutStatus.Started => "STARTED",
                CompletionJobOutStatus.Success => "SUCCESS",
                CompletionJobOutStatus.Validated => "VALIDATED",
                CompletionJobOutStatus.Validating => "VALIDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLATION_REQUESTED" => CompletionJobOutStatus.CancellationRequested,
                "CANCELLED" => CompletionJobOutStatus.Cancelled,
                "FAILED" => CompletionJobOutStatus.Failed,
                "FAILED_VALIDATION" => CompletionJobOutStatus.FailedValidation,
                "QUEUED" => CompletionJobOutStatus.Queued,
                "RUNNING" => CompletionJobOutStatus.Running,
                "STARTED" => CompletionJobOutStatus.Started,
                "SUCCESS" => CompletionJobOutStatus.Success,
                "VALIDATED" => CompletionJobOutStatus.Validated,
                "VALIDATING" => CompletionJobOutStatus.Validating,
                _ => null,
            };
        }
    }
}