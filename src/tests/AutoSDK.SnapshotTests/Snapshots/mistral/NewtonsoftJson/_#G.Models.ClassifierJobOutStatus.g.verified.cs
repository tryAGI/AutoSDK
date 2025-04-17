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
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        QUEUED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STARTED")]
        STARTED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATING")]
        VALIDATING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VALIDATED")]
        VALIDATED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        RUNNING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED_VALIDATION")]
        FAILEDVALIDATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        CANCELLED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLATION_REQUESTED")]
        CANCELLATIONREQUESTED,
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
                ClassifierJobOutStatus.QUEUED => "QUEUED",
                ClassifierJobOutStatus.STARTED => "STARTED",
                ClassifierJobOutStatus.VALIDATING => "VALIDATING",
                ClassifierJobOutStatus.VALIDATED => "VALIDATED",
                ClassifierJobOutStatus.RUNNING => "RUNNING",
                ClassifierJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                ClassifierJobOutStatus.FAILED => "FAILED",
                ClassifierJobOutStatus.SUCCESS => "SUCCESS",
                ClassifierJobOutStatus.CANCELLED => "CANCELLED",
                ClassifierJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
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
                "QUEUED" => ClassifierJobOutStatus.QUEUED,
                "STARTED" => ClassifierJobOutStatus.STARTED,
                "VALIDATING" => ClassifierJobOutStatus.VALIDATING,
                "VALIDATED" => ClassifierJobOutStatus.VALIDATED,
                "RUNNING" => ClassifierJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => ClassifierJobOutStatus.FAILEDVALIDATION,
                "FAILED" => ClassifierJobOutStatus.FAILED,
                "SUCCESS" => ClassifierJobOutStatus.SUCCESS,
                "CANCELLED" => ClassifierJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => ClassifierJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}