//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedWorkflowRunConclusion
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
    public static class WebhookDeploymentCreatedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentCreatedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentCreatedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentCreatedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentCreatedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentCreatedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookDeploymentCreatedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentCreatedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentCreatedWorkflowRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookDeploymentCreatedWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookDeploymentCreatedWorkflowRunConclusion.Cancelled,
                "failure" => WebhookDeploymentCreatedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentCreatedWorkflowRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentCreatedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "stale" => WebhookDeploymentCreatedWorkflowRunConclusion.Stale,
                "success" => WebhookDeploymentCreatedWorkflowRunConclusion.Success,
                "timed_out" => WebhookDeploymentCreatedWorkflowRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}