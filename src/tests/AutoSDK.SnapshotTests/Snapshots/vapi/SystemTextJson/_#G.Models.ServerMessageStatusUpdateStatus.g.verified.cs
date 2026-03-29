//HintName: G.Models.ServerMessageStatusUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the call.
    /// </summary>
    public enum ServerMessageStatusUpdateStatus
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
    public static class ServerMessageStatusUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageStatusUpdateStatus value)
        {
            return value switch
            {
                ServerMessageStatusUpdateStatus.DeletionFailed => "deletion-failed",
                ServerMessageStatusUpdateStatus.Ended => "ended",
                ServerMessageStatusUpdateStatus.Forwarding => "forwarding",
                ServerMessageStatusUpdateStatus.InProgress => "in-progress",
                ServerMessageStatusUpdateStatus.NotFound => "not-found",
                ServerMessageStatusUpdateStatus.Queued => "queued",
                ServerMessageStatusUpdateStatus.Ringing => "ringing",
                ServerMessageStatusUpdateStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageStatusUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "deletion-failed" => ServerMessageStatusUpdateStatus.DeletionFailed,
                "ended" => ServerMessageStatusUpdateStatus.Ended,
                "forwarding" => ServerMessageStatusUpdateStatus.Forwarding,
                "in-progress" => ServerMessageStatusUpdateStatus.InProgress,
                "not-found" => ServerMessageStatusUpdateStatus.NotFound,
                "queued" => ServerMessageStatusUpdateStatus.Queued,
                "ringing" => ServerMessageStatusUpdateStatus.Ringing,
                "scheduled" => ServerMessageStatusUpdateStatus.Scheduled,
                _ => null,
            };
        }
    }
}