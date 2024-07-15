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
                _ => null,
            };
        }
    }
}