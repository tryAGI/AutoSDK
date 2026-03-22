//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewApprovedWorkflowRunStatus
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
    public static class WebhookDeploymentReviewApprovedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Pending => "pending",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Completed,
                "in_progress" => WebhookDeploymentReviewApprovedWorkflowRunStatus.InProgress,
                "pending" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Pending,
                "queued" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Queued,
                "requested" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Requested,
                "waiting" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Waiting,
                _ => null,
            };
        }
    }
}