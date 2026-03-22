//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion
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
        Success,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobVariant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.ActionRequired => "action_required",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Cancelled => "cancelled",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Neutral => "neutral",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.ActionRequired,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Cancelled,
                "failure" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Failure,
                "neutral" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Neutral,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Skipped,
                "success" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Success,
                "timed_out" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.TimedOut,
                _ => null,
            };
        }
    }
}