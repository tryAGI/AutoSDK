//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewRequestedWorkflowRunStatus
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