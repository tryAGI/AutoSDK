//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus
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
    public static class WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus.InProgress => "in_progress",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus.Completed => "completed",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus.InProgress,
                "completed" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus.Completed,
                "queued" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepStatus.Queued,
                _ => null,
            };
        }
    }
}