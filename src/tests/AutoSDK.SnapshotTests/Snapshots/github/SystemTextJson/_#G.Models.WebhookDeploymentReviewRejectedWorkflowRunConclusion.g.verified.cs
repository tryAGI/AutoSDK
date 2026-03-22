//HintName: G.Models.WebhookDeploymentReviewRejectedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRejectedWorkflowRunConclusion
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
    public static class WebhookDeploymentReviewRejectedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRejectedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentReviewRejectedWorkflowRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Cancelled,
                "failure" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "stale" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Stale,
                "success" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.Success,
                "timed_out" => WebhookDeploymentReviewRejectedWorkflowRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}