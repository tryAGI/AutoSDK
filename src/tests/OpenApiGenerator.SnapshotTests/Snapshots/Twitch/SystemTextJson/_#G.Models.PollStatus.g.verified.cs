//HintName: G.Models.PollStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The poll’s status. Valid values are:  
    ///   
    /// * ACTIVE — The poll is running.
    /// * COMPLETED — The poll ended on schedule (see the `duration` field).
    /// * TERMINATED — The poll was terminated before its scheduled end.
    /// * ARCHIVED — The poll has been archived and is no longer visible on the channel.
    /// * MODERATED — The poll was deleted.
    /// * INVALID — Something went wrong while determining the state.
    /// </summary>
    public enum PollStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ACTIVE,
        /// <summary>
        /// 
        /// </summary>
        COMPLETED,
        /// <summary>
        /// 
        /// </summary>
        TERMINATED,
        /// <summary>
        /// 
        /// </summary>
        ARCHIVED,
        /// <summary>
        /// 
        /// </summary>
        MODERATED,
        /// <summary>
        /// 
        /// </summary>
        INVALID,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PollStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PollStatus value)
        {
            return value switch
            {
                PollStatus.ACTIVE => "ACTIVE",
                PollStatus.COMPLETED => "COMPLETED",
                PollStatus.TERMINATED => "TERMINATED",
                PollStatus.ARCHIVED => "ARCHIVED",
                PollStatus.MODERATED => "MODERATED",
                PollStatus.INVALID => "INVALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PollStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PollStatus.ACTIVE,
                "COMPLETED" => PollStatus.COMPLETED,
                "TERMINATED" => PollStatus.TERMINATED,
                "ARCHIVED" => PollStatus.ARCHIVED,
                "MODERATED" => PollStatus.MODERATED,
                "INVALID" => PollStatus.INVALID,
                _ => null,
            };
        }
    }
}