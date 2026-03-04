//HintName: G.Models.PollStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The poll’s status. Valid values are:  <br/>
    ///   <br/>
    /// * ACTIVE — The poll is running.<br/>
    /// * COMPLETED — The poll ended on schedule (see the `duration` field).<br/>
    /// * TERMINATED — The poll was terminated before its scheduled end.<br/>
    /// * ARCHIVED — The poll has been archived and is no longer visible on the channel.<br/>
    /// * MODERATED — The poll was deleted.<br/>
    /// * INVALID — Something went wrong while determining the state.
    /// </summary>
    public enum PollStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Terminated,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Moderated,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
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
                PollStatus.Active => "ACTIVE",
                PollStatus.Completed => "COMPLETED",
                PollStatus.Terminated => "TERMINATED",
                PollStatus.Archived => "ARCHIVED",
                PollStatus.Moderated => "MODERATED",
                PollStatus.Invalid => "INVALID",
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
                "ACTIVE" => PollStatus.Active,
                "COMPLETED" => PollStatus.Completed,
                "TERMINATED" => PollStatus.Terminated,
                "ARCHIVED" => PollStatus.Archived,
                "MODERATED" => PollStatus.Moderated,
                "INVALID" => PollStatus.Invalid,
                _ => null,
            };
        }
    }
}