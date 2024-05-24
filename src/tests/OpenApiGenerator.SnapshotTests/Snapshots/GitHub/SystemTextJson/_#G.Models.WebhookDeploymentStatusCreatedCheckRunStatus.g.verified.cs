//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the check run. Can be `queued`, `in_progress`, or `completed`.
    /// </summary>
    public abstract class WebhookDeploymentStatusCreatedCheckRunStatus
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
        public const string Pending = "pending";
    }
}