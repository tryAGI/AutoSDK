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
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
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
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup_failure")]
        StartupFailure,
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
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Success => "success",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Failure => "failure",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Neutral => "neutral",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Cancelled => "cancelled",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.TimedOut => "timed_out",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.ActionRequired => "action_required",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Stale => "stale",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.Skipped => "skipped",
                WebhookCheckSuiteCompletedCheckSuiteConclusion.StartupFailure => "startup_failure",
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
                "success" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Success,
                "failure" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Failure,
                "neutral" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Neutral,
                "cancelled" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Cancelled,
                "timed_out" => WebhookCheckSuiteCompletedCheckSuiteConclusion.TimedOut,
                "action_required" => WebhookCheckSuiteCompletedCheckSuiteConclusion.ActionRequired,
                "stale" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Stale,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteCompletedCheckSuiteConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                "skipped" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Skipped,
                "startup_failure" => WebhookCheckSuiteCompletedCheckSuiteConclusion.StartupFailure,
                _ => null,
            };
        }
    }
}