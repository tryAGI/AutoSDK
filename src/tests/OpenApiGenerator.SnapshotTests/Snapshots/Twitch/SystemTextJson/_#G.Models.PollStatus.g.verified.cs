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
    public abstract class PollStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ACTIVE = "ACTIVE";
        /// <summary>
        /// 
        /// </summary>
        public const string COMPLETED = "COMPLETED";
        /// <summary>
        /// 
        /// </summary>
        public const string TERMINATED = "TERMINATED";
        /// <summary>
        /// 
        /// </summary>
        public const string ARCHIVED = "ARCHIVED";
        /// <summary>
        /// 
        /// </summary>
        public const string MODERATED = "MODERATED";
        /// <summary>
        /// 
        /// </summary>
        public const string INVALID = "INVALID";
    }
}