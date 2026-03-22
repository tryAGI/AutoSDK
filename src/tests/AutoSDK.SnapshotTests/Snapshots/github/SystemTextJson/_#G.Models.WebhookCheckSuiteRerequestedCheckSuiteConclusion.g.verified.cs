//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has completed.
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteConclusion
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteConclusion value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.ActionRequired => "action_required",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Cancelled => "cancelled",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Failure => "failure",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Neutral => "neutral",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Stale => "stale",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Success => "success",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.ActionRequired,
                "cancelled" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Cancelled,
                "failure" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Failure,
                "neutral" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "stale" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Stale,
                "success" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Success,
                "timed_out" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.TimedOut,
                _ => null,
            };
        }
    }
}