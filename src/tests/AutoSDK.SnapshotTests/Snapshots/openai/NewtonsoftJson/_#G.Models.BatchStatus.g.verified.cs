//HintName: G.Models.BatchStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the batch.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelling")]
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finalizing")]
        Finalizing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatus value)
        {
            return value switch
            {
                BatchStatus.Cancelled => "cancelled",
                BatchStatus.Cancelling => "cancelling",
                BatchStatus.Completed => "completed",
                BatchStatus.Expired => "expired",
                BatchStatus.Failed => "failed",
                BatchStatus.Finalizing => "finalizing",
                BatchStatus.InProgress => "in_progress",
                BatchStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BatchStatus.Cancelled,
                "cancelling" => BatchStatus.Cancelling,
                "completed" => BatchStatus.Completed,
                "expired" => BatchStatus.Expired,
                "failed" => BatchStatus.Failed,
                "finalizing" => BatchStatus.Finalizing,
                "in_progress" => BatchStatus.InProgress,
                "validating" => BatchStatus.Validating,
                _ => null,
            };
        }
    }
}