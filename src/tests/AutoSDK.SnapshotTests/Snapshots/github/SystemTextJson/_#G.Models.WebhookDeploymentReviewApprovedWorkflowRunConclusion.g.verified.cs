//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewApprovedWorkflowRunConclusion
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
    public static class WebhookDeploymentReviewApprovedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Cancelled,
                "failure" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "stale" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Stale,
                "success" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Success,
                "timed_out" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}