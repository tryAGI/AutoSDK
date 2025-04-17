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
    public static class ClassifierDetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierDetailedJobOutStatus value)
        {
            return value switch
            {
                ClassifierDetailedJobOutStatus.QUEUED => "QUEUED",
                ClassifierDetailedJobOutStatus.STARTED => "STARTED",
                ClassifierDetailedJobOutStatus.VALIDATING => "VALIDATING",
                ClassifierDetailedJobOutStatus.VALIDATED => "VALIDATED",
                ClassifierDetailedJobOutStatus.RUNNING => "RUNNING",
                ClassifierDetailedJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                ClassifierDetailedJobOutStatus.FAILED => "FAILED",
                ClassifierDetailedJobOutStatus.SUCCESS => "SUCCESS",
                ClassifierDetailedJobOutStatus.CANCELLED => "CANCELLED",
                ClassifierDetailedJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
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
                "QUEUED" => ClassifierDetailedJobOutStatus.QUEUED,
                "STARTED" => ClassifierDetailedJobOutStatus.STARTED,
                "VALIDATING" => ClassifierDetailedJobOutStatus.VALIDATING,
                "VALIDATED" => ClassifierDetailedJobOutStatus.VALIDATED,
                "RUNNING" => ClassifierDetailedJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => ClassifierDetailedJobOutStatus.FAILEDVALIDATION,
                "FAILED" => ClassifierDetailedJobOutStatus.FAILED,
                "SUCCESS" => ClassifierDetailedJobOutStatus.SUCCESS,
                "CANCELLED" => ClassifierDetailedJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => ClassifierDetailedJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}