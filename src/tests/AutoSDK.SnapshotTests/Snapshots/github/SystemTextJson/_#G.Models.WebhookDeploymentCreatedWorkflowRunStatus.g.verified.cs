//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedWorkflowRunStatus
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
    public static class WebhookDeploymentCreatedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentCreatedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentCreatedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentCreatedWorkflowRunStatus.Pending => "pending",
                WebhookDeploymentCreatedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentCreatedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentCreatedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookDeploymentCreatedWorkflowRunStatus.Completed,
                "in_progress" => WebhookDeploymentCreatedWorkflowRunStatus.InProgress,
                "pending" => WebhookDeploymentCreatedWorkflowRunStatus.Pending,
                "queued" => WebhookDeploymentCreatedWorkflowRunStatus.Queued,
                "requested" => WebhookDeploymentCreatedWorkflowRunStatus.Requested,
                "waiting" => WebhookDeploymentCreatedWorkflowRunStatus.Waiting,
                _ => null,
            };
        }
    }
}