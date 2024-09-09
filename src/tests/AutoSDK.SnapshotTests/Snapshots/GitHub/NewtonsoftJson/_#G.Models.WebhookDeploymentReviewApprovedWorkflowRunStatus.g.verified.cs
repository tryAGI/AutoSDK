//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewApprovedWorkflowRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
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
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Waiting => "waiting",
                WebhookDeploymentReviewApprovedWorkflowRunStatus.Pending => "pending",
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
                "requested" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Requested,
                "in_progress" => WebhookDeploymentReviewApprovedWorkflowRunStatus.InProgress,
                "completed" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Completed,
                "queued" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Queued,
                "waiting" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Waiting,
                "pending" => WebhookDeploymentReviewApprovedWorkflowRunStatus.Pending,
                _ => null,
            };
        }
    }
}