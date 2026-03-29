//HintName: G.Models.BatchJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of a batch processing job.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dispatched")]
        Dispatched,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
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
                BatchJobStatus.Cancelled => "cancelled",
                BatchJobStatus.Completed => "completed",
                BatchJobStatus.Dispatched => "dispatched",
                BatchJobStatus.Failed => "failed",
                BatchJobStatus.Pending => "pending",
                BatchJobStatus.Running => "running",
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
                "cancelled" => BatchJobStatus.Cancelled,
                "completed" => BatchJobStatus.Completed,
                "dispatched" => BatchJobStatus.Dispatched,
                "failed" => BatchJobStatus.Failed,
                "pending" => BatchJobStatus.Pending,
                "running" => BatchJobStatus.Running,
                _ => null,
            };
        }
    }
}