//HintName: G.Models.WebhookDeploymentStatusCreatedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedWorkflowRunConclusion
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
        StartupFailure,
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
    public static class WebhookDeploymentStatusCreatedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.StartupFailure => "startup_failure",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Cancelled,
                "failure" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "stale" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Stale,
                "startup_failure" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.StartupFailure,
                "success" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Success,
                "timed_out" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}