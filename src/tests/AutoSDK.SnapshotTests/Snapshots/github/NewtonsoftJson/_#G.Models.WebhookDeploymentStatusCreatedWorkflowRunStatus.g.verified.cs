//HintName: G.Models.WebhookDeploymentStatusCreatedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedWorkflowRunStatus
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
    public static class WebhookDeploymentStatusCreatedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Pending => "pending",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentStatusCreatedWorkflowRunStatus.Waiting => "waiting",
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
                "completed" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Completed,
                "in_progress" => WebhookDeploymentStatusCreatedWorkflowRunStatus.InProgress,
                "pending" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Pending,
                "queued" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Queued,
                "requested" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Requested,
                "waiting" => WebhookDeploymentStatusCreatedWorkflowRunStatus.Waiting,
                _ => null,
            };
        }
    }
}