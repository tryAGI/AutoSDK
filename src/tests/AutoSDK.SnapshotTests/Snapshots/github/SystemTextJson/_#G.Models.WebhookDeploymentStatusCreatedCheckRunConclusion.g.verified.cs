//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the completed check run. This value will be `null` until the check run has completed.
    /// </summary>
    public enum WebhookDeploymentStatusCreatedCheckRunConclusion
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
        Skipped,
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
    public static class WebhookDeploymentStatusCreatedCheckRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedCheckRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedCheckRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Failure => "failure",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Neutral => "neutral",
                WebhookDeploymentStatusCreatedCheckRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Skipped => "skipped",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Stale => "stale",
                WebhookDeploymentStatusCreatedCheckRunConclusion.Success => "success",
                WebhookDeploymentStatusCreatedCheckRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedCheckRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookDeploymentStatusCreatedCheckRunConclusion.ActionRequired,
                "cancelled" => WebhookDeploymentStatusCreatedCheckRunConclusion.Cancelled,
                "failure" => WebhookDeploymentStatusCreatedCheckRunConclusion.Failure,
                "neutral" => WebhookDeploymentStatusCreatedCheckRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentStatusCreatedCheckRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookDeploymentStatusCreatedCheckRunConclusion.Skipped,
                "stale" => WebhookDeploymentStatusCreatedCheckRunConclusion.Stale,
                "success" => WebhookDeploymentStatusCreatedCheckRunConclusion.Success,
                "timed_out" => WebhookDeploymentStatusCreatedCheckRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}