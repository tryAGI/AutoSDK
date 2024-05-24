//HintName: G.Models.JobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.
    /// <br/>Example: queued
    /// </summary>
    public abstract class JobStepsStatus
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
    }
}