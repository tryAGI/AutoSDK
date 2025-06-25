﻿//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunInProgressWorkflowRunConclusion
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
    public static class WebhookWorkflowRunInProgressWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookWorkflowRunInProgressWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookWorkflowRunInProgressWorkflowRunConclusion.Failure => "failure",
                WebhookWorkflowRunInProgressWorkflowRunConclusion.Neutral => "neutral",
                WebhookWorkflowRunInProgressWorkflowRunConclusion.Skipped => "skipped",
                WebhookWorkflowRunInProgressWorkflowRunConclusion.Stale => "stale",
                WebhookWorkflowRunInProgressWorkflowRunConclusion.Success => "success",
                WebhookWorkflowRunInProgressWorkflowRunConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookWorkflowRunInProgressWorkflowRunConclusion.ActionRequired,
                "cancelled" => WebhookWorkflowRunInProgressWorkflowRunConclusion.Cancelled,
                "failure" => WebhookWorkflowRunInProgressWorkflowRunConclusion.Failure,
                "neutral" => WebhookWorkflowRunInProgressWorkflowRunConclusion.Neutral,
                "skipped" => WebhookWorkflowRunInProgressWorkflowRunConclusion.Skipped,
                "stale" => WebhookWorkflowRunInProgressWorkflowRunConclusion.Stale,
                "success" => WebhookWorkflowRunInProgressWorkflowRunConclusion.Success,
                "timed_out" => WebhookWorkflowRunInProgressWorkflowRunConclusion.TimedOut,
                _ => null,
            };
        }
    }
}