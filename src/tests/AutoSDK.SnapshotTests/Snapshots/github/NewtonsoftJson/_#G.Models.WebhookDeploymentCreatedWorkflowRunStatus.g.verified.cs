//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedWorkflowRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
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