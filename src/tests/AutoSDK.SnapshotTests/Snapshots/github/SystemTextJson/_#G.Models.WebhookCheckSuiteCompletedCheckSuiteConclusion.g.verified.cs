//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has `completed`.
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteConclusion
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
    public static class WebhookCheckSuiteCompletedCheckSuiteConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteConclusion value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteConclusion.ActionRequired => "action_required",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Cancelled => "cancelled",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Failure => "failure",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Neutral => "neutral",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Skipped => "skipped",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Stale => "stale",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.StartupFailure => "startup_failure",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Success => "success",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookCheckSuiteCompletedCheckSuiteConclusion.ActionRequired,
                "cancelled" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Cancelled,
                "failure" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Failure,
                "neutral" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteCompletedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Skipped,
                "stale" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Stale,
                "startup_failure" => WebhookCheckSuiteCompletedCheckSuiteConclusion.StartupFailure,
                "success" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Success,
                "timed_out" => WebhookCheckSuiteCompletedCheckSuiteConclusion.TimedOut,
                _ => null,
            };
        }
    }
}