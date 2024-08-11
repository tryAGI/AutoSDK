//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobQueuedWorkflowJobStepConclusion
    {
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
        Success,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobQueuedWorkflowJobStepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedWorkflowJobStepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Failure => "failure",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Skipped => "skipped",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Success => "success",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedWorkflowJobStepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Failure,
                "skipped" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Skipped,
                "success" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Success,
                "cancelled" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Cancelled,
                _ => null,
            };
        }
    }
}