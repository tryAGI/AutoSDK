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
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATING")]
        Validating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATED")]
        Validated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED_VALIDATION")]
        FailedValidation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLATION_REQUESTED")]
        CancellationRequested,
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
                CompletionJobOutStatus.Queued => "QUEUED",
                CompletionJobOutStatus.Started => "STARTED",
                CompletionJobOutStatus.Validating => "VALIDATING",
                CompletionJobOutStatus.Validated => "VALIDATED",
                CompletionJobOutStatus.Running => "RUNNING",
                CompletionJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                CompletionJobOutStatus.Failed => "FAILED",
                CompletionJobOutStatus.Success => "SUCCESS",
                CompletionJobOutStatus.Cancelled => "CANCELLED",
                CompletionJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
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
                "QUEUED" => CompletionJobOutStatus.Queued,
                "STARTED" => CompletionJobOutStatus.Started,
                "VALIDATING" => CompletionJobOutStatus.Validating,
                "VALIDATED" => CompletionJobOutStatus.Validated,
                "RUNNING" => CompletionJobOutStatus.Running,
                "FAILED_VALIDATION" => CompletionJobOutStatus.FailedValidation,
                "FAILED" => CompletionJobOutStatus.Failed,
                "SUCCESS" => CompletionJobOutStatus.Success,
                "CANCELLED" => CompletionJobOutStatus.Cancelled,
                "CANCELLATION_REQUESTED" => CompletionJobOutStatus.CancellationRequested,
                _ => null,
            };
        }
    }
}