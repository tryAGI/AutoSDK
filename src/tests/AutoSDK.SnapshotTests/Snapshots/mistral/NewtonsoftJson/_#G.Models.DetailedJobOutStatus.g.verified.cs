//HintName: G.Models.DetailedJobOutStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DetailedJobOutStatus
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
    public static class DetailedJobOutStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailedJobOutStatus value)
        {
            return value switch
            {
                DetailedJobOutStatus.QUEUED => "QUEUED",
                DetailedJobOutStatus.STARTED => "STARTED",
                DetailedJobOutStatus.VALIDATING => "VALIDATING",
                DetailedJobOutStatus.VALIDATED => "VALIDATED",
                DetailedJobOutStatus.RUNNING => "RUNNING",
                DetailedJobOutStatus.FAILEDVALIDATION => "FAILED_VALIDATION",
                DetailedJobOutStatus.FAILED => "FAILED",
                DetailedJobOutStatus.SUCCESS => "SUCCESS",
                DetailedJobOutStatus.CANCELLED => "CANCELLED",
                DetailedJobOutStatus.CANCELLATIONREQUESTED => "CANCELLATION_REQUESTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailedJobOutStatus? ToEnum(string value)
        {
            return value switch
            {
                "QUEUED" => DetailedJobOutStatus.QUEUED,
                "STARTED" => DetailedJobOutStatus.STARTED,
                "VALIDATING" => DetailedJobOutStatus.VALIDATING,
                "VALIDATED" => DetailedJobOutStatus.VALIDATED,
                "RUNNING" => DetailedJobOutStatus.RUNNING,
                "FAILED_VALIDATION" => DetailedJobOutStatus.FAILEDVALIDATION,
                "FAILED" => DetailedJobOutStatus.FAILED,
                "SUCCESS" => DetailedJobOutStatus.SUCCESS,
                "CANCELLED" => DetailedJobOutStatus.CANCELLED,
                "CANCELLATION_REQUESTED" => DetailedJobOutStatus.CANCELLATIONREQUESTED,
                _ => null,
            };
        }
    }
}