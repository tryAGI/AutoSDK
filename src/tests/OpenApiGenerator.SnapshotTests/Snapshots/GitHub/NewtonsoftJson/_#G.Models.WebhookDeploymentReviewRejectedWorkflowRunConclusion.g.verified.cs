//HintName: G.Models.WebhookDeploymentReviewRejectedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewRejectedWorkflowRunConclusion
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
    public static class WebhookDeploymentReviewRejectedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRejectedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.TimedOut => "timed_out",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Stale => "stale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedWorkflowRunConclusion ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Success,
                "failure" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Neutral,
                "cancelled" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Cancelled,
                "timed_out" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.TimedOut,
                "action_required" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.ActionRequired,
                "stale" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Stale,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}