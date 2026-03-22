//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRequestedWorkflowRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Requested,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewRequestedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Pending => "pending",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Completed,
                "in_progress" => WebhookDeploymentReviewRequestedWorkflowRunStatus.InProgress,
                "pending" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Pending,
                "queued" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Queued,
                "requested" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Requested,
                "waiting" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Waiting,
                _ => null,
            };
        }
    }
}