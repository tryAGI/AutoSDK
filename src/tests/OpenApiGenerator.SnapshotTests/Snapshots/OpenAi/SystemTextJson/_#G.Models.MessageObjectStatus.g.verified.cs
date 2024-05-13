//HintName: G.Models.MessageObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message, which can be either `in_progress`, `incomplete`, or `completed`.
    /// </summary>
    public abstract class MessageObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Incomplete = "incomplete";
        /// <summary>
        /// 
        /// </summary>
        public const string Completed = "completed";
    }
}