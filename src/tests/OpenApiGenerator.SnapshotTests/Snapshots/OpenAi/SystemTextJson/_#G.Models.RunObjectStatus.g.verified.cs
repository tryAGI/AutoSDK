//HintName: G.Models.RunObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, or `expired`.
    /// </summary>
    public abstract class RunObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Queued = "queued";
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string RequiresAction = "requires_action";
        /// <summary>
        /// 
        /// </summary>
        public const string Cancelling = "cancelling";
        /// <summary>
        /// 
        /// </summary>
        public const string Cancelled = "cancelled";
        /// <summary>
        /// 
        /// </summary>
        public const string Failed = "failed";
        /// <summary>
        /// 
        /// </summary>
        public const string Completed = "completed";
        /// <summary>
        /// 
        /// </summary>
        public const string Expired = "expired";
    }
}