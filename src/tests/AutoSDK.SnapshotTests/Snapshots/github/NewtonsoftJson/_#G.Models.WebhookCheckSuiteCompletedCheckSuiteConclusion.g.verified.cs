//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary conclusion for all check runs that are part of the check suite. This value will be `null` until the check run has `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteCompletedCheckSuiteConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup_failure")]
        StartupFailure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
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