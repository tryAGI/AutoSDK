//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus.InProgress => "in_progress",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus.Completed => "completed",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus.InProgress,
                "completed" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus.Completed,
                "queued" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepStatus.Queued,
                _ => null,
            };
        }
    }
}