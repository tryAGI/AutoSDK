﻿//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteConclusion.g.cs

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
        /// <summary>
        /// 
        /// </summary>
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
                "skipped" => WebhookCheckSuiteCompletedCheckSuiteConclusion.Skipped,
                "startup_failure" => WebhookCheckSuiteCompletedCheckSuiteConclusion.StartupFailure,
                _ => null,
            };
        }
    }
}