//HintName: G.Models.CallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the call.
    /// </summary>
    public enum CallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        DeletionFailed,
        /// <summary>
        /// 
        /// </summary>
        Ended,
        /// <summary>
        /// 
        /// </summary>
        Forwarding,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Ringing,
        /// <summary>
        /// 
        /// </summary>
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