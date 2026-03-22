//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunRequestedWorkflowRunConclusion
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
    public static class WebhookWorkflowRunRequestedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Failure => "failure",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Neutral => "neutral",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Skipped => "skipped",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Stale => "stale",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.StartupFailure => "startup_failure",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.Success => "success",
                WebhookWorkflowRunRequestedWorkflowRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookWorkflowRunRequestedWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Cancelled,
                "failure" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Failure,
                "neutral" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowRunRequestedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Skipped,
                "stale" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Stale,
                "startup_failure" => WebhookWorkflowRunRequestedWorkflowRunConclusion.StartupFailure,
                "success" => WebhookWorkflowRunRequestedWorkflowRunConclusion.Success,
                "timed_out" => WebhookWorkflowRunRequestedWorkflowRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}