//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobWaitingWorkflowJobStepsConclusion
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
    public static class WebhookWorkflowJobWaitingWorkflowJobStepsConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStepsConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Failure => "failure",
                WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Skipped => "skipped",
                WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Success => "success",
                WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStepsConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Failure,
                "skipped" => WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Skipped,
                "success" => WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Success,
                "cancelled" => WebhookWorkflowJobWaitingWorkflowJobStepsConclusion.Cancelled,
                _ => null,
            };
        }
    }
}