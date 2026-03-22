//HintName: G.Models.CompletionDetailedJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionDetailedJobOutStatus
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
    public static class CompletionDetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionDetailedJobOutStatus value)
        {
            return value switch
            {
                CompletionDetailedJobOutStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                CompletionDetailedJobOutStatus.Cancelled => "CANCELLED",
                CompletionDetailedJobOutStatus.Failed => "FAILED",
                CompletionDetailedJobOutStatus.FailedValidation => "FAILED_VALIDATION",
                CompletionDetailedJobOutStatus.Queued => "QUEUED",
                CompletionDetailedJobOutStatus.Running => "RUNNING",
                CompletionDetailedJobOutStatus.Started => "STARTED",
                CompletionDetailedJobOutStatus.Success => "SUCCESS",
                CompletionDetailedJobOutStatus.Validated => "VALIDATED",
                CompletionDetailedJobOutStatus.Validating => "VALIDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionDetailedJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLATION_REQUESTED" => CompletionDetailedJobOutStatus.CancellationRequested,
                "CANCELLED" => CompletionDetailedJobOutStatus.Cancelled,
                "FAILED" => CompletionDetailedJobOutStatus.Failed,
                "FAILED_VALIDATION" => CompletionDetailedJobOutStatus.FailedValidation,
                "QUEUED" => CompletionDetailedJobOutStatus.Queued,
                "RUNNING" => CompletionDetailedJobOutStatus.Running,
                "STARTED" => CompletionDetailedJobOutStatus.Started,
                "SUCCESS" => CompletionDetailedJobOutStatus.Success,
                "VALIDATED" => CompletionDetailedJobOutStatus.Validated,
                "VALIDATING" => CompletionDetailedJobOutStatus.Validating,
                _ => null,
            };
        }
    }
}