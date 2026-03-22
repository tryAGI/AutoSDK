//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has completed.
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteConclusion
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
    public static class WebhookCheckSuiteRequestedCheckSuiteConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteConclusion value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteConclusion.ActionRequired => "action_required",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Cancelled => "cancelled",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Failure => "failure",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Neutral => "neutral",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Skipped => "skipped",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Stale => "stale",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Success => "success",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookCheckSuiteRequestedCheckSuiteConclusion.ActionRequired,
                "cancelled" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Cancelled,
                "failure" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Failure,
                "neutral" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteRequestedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Skipped,
                "stale" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Stale,
                "success" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Success,
                "timed_out" => WebhookCheckSuiteRequestedCheckSuiteConclusion.TimedOut,
                _ => null,
            };
        }
    }
}