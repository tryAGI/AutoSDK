//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewRequestedWorkflowRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewRequestedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.TimedOut => "timed_out",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Stale => "stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedWorkflowRunConclusion ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Success,
                "failure" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Neutral,
                "cancelled" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Cancelled,
                "timed_out" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.TimedOut,
                "action_required" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.ActionRequired,
                "stale" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Stale,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}