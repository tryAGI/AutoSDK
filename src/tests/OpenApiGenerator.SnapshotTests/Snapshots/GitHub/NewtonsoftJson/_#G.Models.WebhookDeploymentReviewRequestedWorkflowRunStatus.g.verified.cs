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
    public static class WebhookDeploymentReviewRequestedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Requested => "requested",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.InProgress => "in_progress",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Completed => "completed",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Queued => "queued",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Waiting => "waiting",
                WebhookDeploymentReviewRequestedWorkflowRunStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedWorkflowRunStatus ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Requested,
                "in_progress" => WebhookDeploymentReviewRequestedWorkflowRunStatus.InProgress,
                "completed" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Completed,
                "queued" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Queued,
                "waiting" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Waiting,
                "pending" => WebhookDeploymentReviewRequestedWorkflowRunStatus.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}