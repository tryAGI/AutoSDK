//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRequestedWorkflowRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
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
        public static WebhookDeploymentReviewRequestedWorkflowRunConclusion? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}