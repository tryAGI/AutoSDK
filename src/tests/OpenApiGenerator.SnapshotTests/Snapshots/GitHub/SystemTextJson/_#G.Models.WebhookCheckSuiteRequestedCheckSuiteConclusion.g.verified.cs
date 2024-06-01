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
        Skipped,
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
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Success => "success",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Failure => "failure",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Neutral => "neutral",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Cancelled => "cancelled",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.TimedOut => "timed_out",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.ActionRequired => "action_required",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Stale => "stale",
                WebhookCheckSuiteRequestedCheckSuiteConclusion.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteConclusion ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Success,
                "failure" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Failure,
                "neutral" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Neutral,
                "cancelled" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Cancelled,
                "timed_out" => WebhookCheckSuiteRequestedCheckSuiteConclusion.TimedOut,
                "action_required" => WebhookCheckSuiteRequestedCheckSuiteConclusion.ActionRequired,
                "stale" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Stale,
                "skipped" => WebhookCheckSuiteRequestedCheckSuiteConclusion.Skipped,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}