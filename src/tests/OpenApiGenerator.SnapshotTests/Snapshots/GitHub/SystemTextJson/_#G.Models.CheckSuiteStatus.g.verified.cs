//HintName: G.Models.CheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of the lifecycle that the check suite is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check suites.
    /// <br/>Example: completed
    /// </summary>
    public abstract class CheckSuiteStatus
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