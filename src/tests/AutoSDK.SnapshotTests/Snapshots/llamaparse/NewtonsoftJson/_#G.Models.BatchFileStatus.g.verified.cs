//HintName: G.Models.BatchFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of an individual file in a batch job.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchFileStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchFileStatus value)
        {
            return value switch
            {
                BatchFileStatus.Cancelled => "cancelled",
                BatchFileStatus.Completed => "completed",
                BatchFileStatus.Failed => "failed",
                BatchFileStatus.Pending => "pending",
                BatchFileStatus.Processing => "processing",
                BatchFileStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BatchFileStatus.Cancelled,
                "completed" => BatchFileStatus.Completed,
                "failed" => BatchFileStatus.Failed,
                "pending" => BatchFileStatus.Pending,
                "processing" => BatchFileStatus.Processing,
                "skipped" => BatchFileStatus.Skipped,
                _ => null,
            };
        }
    }
}