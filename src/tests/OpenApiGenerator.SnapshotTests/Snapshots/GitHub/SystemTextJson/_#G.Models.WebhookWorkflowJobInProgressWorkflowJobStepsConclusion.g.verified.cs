//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobStepsConclusion
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
    public static class WebhookWorkflowJobInProgressWorkflowJobStepsConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobStepsConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Skipped => "skipped",
                WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Success => "success",
                WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobStepsConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Failure,
                "skipped" => WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Skipped,
                "success" => WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Success,
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobStepsConclusion.Cancelled,
                _ => null,
            };
        }
    }
}