//HintName: G.Models.CallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deletion-failed")]
        DeletionFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ended")]
        Ended,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forwarding")]
        Forwarding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in-progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not-found")]
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ringing")]
        Ringing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scheduled")]
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallStatus value)
        {
            return value switch
            {
                CallStatus.DeletionFailed => "deletion-failed",
                CallStatus.Ended => "ended",
                CallStatus.Forwarding => "forwarding",
                CallStatus.InProgress => "in-progress",
                CallStatus.NotFound => "not-found",
                CallStatus.Queued => "queued",
                CallStatus.Ringing => "ringing",
                CallStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallStatus? ToEnum(string value)
        {
            return value switch
            {
                "deletion-failed" => CallStatus.DeletionFailed,
                "ended" => CallStatus.Ended,
                "forwarding" => CallStatus.Forwarding,
                "in-progress" => CallStatus.InProgress,
                "not-found" => CallStatus.NotFound,
                "queued" => CallStatus.Queued,
                "ringing" => CallStatus.Ringing,
                "scheduled" => CallStatus.Scheduled,
                _ => null,
            };
        }
    }
}