//HintName: G.Models.BatchCallRecipientStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchCallRecipientStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="initiated")]
        Initiated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
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
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchCallRecipientStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchCallRecipientStatus value)
        {
            return value switch
            {
                BatchCallRecipientStatus.Pending => "pending",
                BatchCallRecipientStatus.Initiated => "initiated",
                BatchCallRecipientStatus.InProgress => "in_progress",
                BatchCallRecipientStatus.Completed => "completed",
                BatchCallRecipientStatus.Failed => "failed",
                BatchCallRecipientStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchCallRecipientStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => BatchCallRecipientStatus.Pending,
                "initiated" => BatchCallRecipientStatus.Initiated,
                "in_progress" => BatchCallRecipientStatus.InProgress,
                "completed" => BatchCallRecipientStatus.Completed,
                "failed" => BatchCallRecipientStatus.Failed,
                "cancelled" => BatchCallRecipientStatus.Cancelled,
                _ => null,
            };
        }
    }
}