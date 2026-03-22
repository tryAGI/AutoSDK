//HintName: G.Models.BatchJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchJobStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TIMEOUT_EXCEEDED")]
        TimeoutExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchJobStatus value)
        {
            return value switch
            {
                BatchJobStatus.CancellationRequested => "CANCELLATION_REQUESTED",
                BatchJobStatus.Cancelled => "CANCELLED",
                BatchJobStatus.Failed => "FAILED",
                BatchJobStatus.Queued => "QUEUED",
                BatchJobStatus.Running => "RUNNING",
                BatchJobStatus.Success => "SUCCESS",
                BatchJobStatus.TimeoutExceeded => "TIMEOUT_EXCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLATION_REQUESTED" => BatchJobStatus.CancellationRequested,
                "CANCELLED" => BatchJobStatus.Cancelled,
                "FAILED" => BatchJobStatus.Failed,
                "QUEUED" => BatchJobStatus.Queued,
                "RUNNING" => BatchJobStatus.Running,
                "SUCCESS" => BatchJobStatus.Success,
                "TIMEOUT_EXCEEDED" => BatchJobStatus.TimeoutExceeded,
                _ => null,
            };
        }
    }
}