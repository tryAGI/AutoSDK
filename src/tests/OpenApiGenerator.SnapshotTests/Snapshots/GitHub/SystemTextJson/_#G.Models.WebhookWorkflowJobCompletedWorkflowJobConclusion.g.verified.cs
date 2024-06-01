//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobConclusion
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
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobConclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobConclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobConclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobCompletedWorkflowJobConclusion.ActionRequired => "action_required",
                WebhookWorkflowJobCompletedWorkflowJobConclusion.Neutral => "neutral",
                WebhookWorkflowJobCompletedWorkflowJobConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobConclusion ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowJobCompletedWorkflowJobConclusion.Success,
                "failure" => WebhookWorkflowJobCompletedWorkflowJobConclusion.Failure,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobConclusion.Skipped,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobConclusion.Cancelled,
                "action_required" => WebhookWorkflowJobCompletedWorkflowJobConclusion.ActionRequired,
                "neutral" => WebhookWorkflowJobCompletedWorkflowJobConclusion.Neutral,
                "timed_out" => WebhookWorkflowJobCompletedWorkflowJobConclusion.TimedOut,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}