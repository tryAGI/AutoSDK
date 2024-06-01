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
        Requested,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
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
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentReviewRejectedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedWorkflowRunStatus ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Requested,
                "in_progress" => WebhookDeploymentReviewRejectedWorkflowRunStatus.InProgress,
                "completed" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Completed,
                "queued" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Queued,
                "waiting" => WebhookDeploymentReviewRejectedWorkflowRunStatus.Waiting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}