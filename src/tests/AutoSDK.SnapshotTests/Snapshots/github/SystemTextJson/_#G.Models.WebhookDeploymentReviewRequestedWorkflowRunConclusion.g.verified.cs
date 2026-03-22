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
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
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
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentReviewRequestedWorkflowRunConclusion.TimedOut => "timed_out",
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
                "action_required" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Cancelled,
                "failure" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "stale" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Stale,
                "success" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.Success,
                "timed_out" => WebhookDeploymentReviewRequestedWorkflowRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}