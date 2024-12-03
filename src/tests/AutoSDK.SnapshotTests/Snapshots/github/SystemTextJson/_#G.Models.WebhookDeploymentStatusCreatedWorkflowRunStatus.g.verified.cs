//HintName: G.Models.WebhookDeploymentStatusCreatedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedWorkflowRunStatus
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
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Waiting => "waiting",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Requested,
                "in_progress" => WebhookDeploymentStatusCreatedWorkflowRunStatus.InProgress,
                "completed" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Completed,
                "queued" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Queued,
                "waiting" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Waiting,
                "pending" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Pending,
                _ => null,
            };
        }
    }
}