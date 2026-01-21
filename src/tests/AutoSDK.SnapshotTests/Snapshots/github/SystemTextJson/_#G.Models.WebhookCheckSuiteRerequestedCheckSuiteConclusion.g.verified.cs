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
        Success,
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
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Success => "success",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Failure => "failure",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Neutral => "neutral",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Cancelled => "cancelled",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.TimedOut => "timed_out",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.ActionRequired => "action_required",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.Stale => "stale",
                WebhookCheckSuiteRerequestedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "success" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Success,
                "failure" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Failure,
                "neutral" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Neutral,
                "cancelled" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Cancelled,
                "timed_out" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.TimedOut,
                "action_required" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.ActionRequired,
                "stale" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.Stale,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteRerequestedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}