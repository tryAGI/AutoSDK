//HintName: G.Models.JobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.
    /// <br/>Example: queued
    /// </summary>
    public abstract class JobStatus
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
        public const string Completed = "completed";
        /// <summary>
        /// 
        /// </summary>
        public const string Waiting = "waiting";
        /// <summary>
        /// 
        /// </summary>
        public const string Requested = "requested";
        /// <summary>
        /// 
        /// </summary>
        public const string Pending = "pending";
    }
}