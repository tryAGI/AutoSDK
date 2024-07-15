//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobStepsConclusion
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
    public static class WebhookWorkflowJobCompletedWorkflowJobStepsConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobStepsConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobStepsConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Failure,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Skipped,
                "success" => WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Success,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobStepsConclusion.Cancelled,
                _ => null,
            };
        }
    }
}