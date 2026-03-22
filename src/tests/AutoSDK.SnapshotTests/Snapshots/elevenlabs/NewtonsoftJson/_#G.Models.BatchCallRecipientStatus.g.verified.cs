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
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="initiated")]
        Initiated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail")]
        Voicemail,
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
                BatchCallRecipientStatus.Cancelled => "cancelled",
                BatchCallRecipientStatus.Completed => "completed",
                BatchCallRecipientStatus.Dispatched => "dispatched",
                BatchCallRecipientStatus.Failed => "failed",
                BatchCallRecipientStatus.InProgress => "in_progress",
                BatchCallRecipientStatus.Initiated => "initiated",
                BatchCallRecipientStatus.Pending => "pending",
                BatchCallRecipientStatus.Voicemail => "voicemail",
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
                "cancelled" => BatchCallRecipientStatus.Cancelled,
                "completed" => BatchCallRecipientStatus.Completed,
                "dispatched" => BatchCallRecipientStatus.Dispatched,
                "failed" => BatchCallRecipientStatus.Failed,
                "in_progress" => BatchCallRecipientStatus.InProgress,
                "initiated" => BatchCallRecipientStatus.Initiated,
                "pending" => BatchCallRecipientStatus.Pending,
                "voicemail" => BatchCallRecipientStatus.Voicemail,
                _ => null,
            };
        }
    }
}