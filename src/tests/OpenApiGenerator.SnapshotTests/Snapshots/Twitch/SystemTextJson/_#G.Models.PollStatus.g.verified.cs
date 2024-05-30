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

    public static class PollStatusExtensions
    {
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
        public static PollStatus ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PollStatus.ACTIVE,
                "COMPLETED" => PollStatus.COMPLETED,
                "TERMINATED" => PollStatus.TERMINATED,
                "ARCHIVED" => PollStatus.ARCHIVED,
                "MODERATED" => PollStatus.MODERATED,
                "INVALID" => PollStatus.INVALID,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PollStatus ToEnum(int value)
        {
            return value switch
            {
                0 => PollStatus.ACTIVE,
                1 => PollStatus.COMPLETED,
                2 => PollStatus.TERMINATED,
                3 => PollStatus.ARCHIVED,
                4 => PollStatus.MODERATED,
                5 => PollStatus.INVALID,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}