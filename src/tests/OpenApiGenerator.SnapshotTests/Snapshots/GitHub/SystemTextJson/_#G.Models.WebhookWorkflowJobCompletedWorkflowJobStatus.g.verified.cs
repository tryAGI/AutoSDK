//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, `waiting`, or `completed`.
    /// </summary>
    public abstract class WebhookWorkflowJobCompletedWorkflowJobStatus
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
    }
}