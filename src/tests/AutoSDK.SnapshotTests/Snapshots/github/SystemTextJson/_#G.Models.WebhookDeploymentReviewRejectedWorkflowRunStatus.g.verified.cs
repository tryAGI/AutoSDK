//HintName: G.Models.WebhookDeploymentReviewRejectedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRejectedWorkflowRunStatus
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
    public static class WebhookDeploymentReviewRejectedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRejectedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Completed,
                "in_progress" => WebhookDeploymentReviewRejectedWorkflowRunStatus.InProgress,
                "queued" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Queued,
                "requested" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Requested,
                "waiting" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Waiting,
                _ => null,
            };
        }
    }
}