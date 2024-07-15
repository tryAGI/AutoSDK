//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobStepsStatus
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
    public static class WebhookWorkflowJobCompletedWorkflowJobStepsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobStepsStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobStepsStatus.InProgress => "in_progress",
                WebhookWorkflowJobCompletedWorkflowJobStepsStatus.Completed => "completed",
                WebhookWorkflowJobCompletedWorkflowJobStepsStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobStepsStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobCompletedWorkflowJobStepsStatus.InProgress,
                "completed" => WebhookWorkflowJobCompletedWorkflowJobStepsStatus.Completed,
                "queued" => WebhookWorkflowJobCompletedWorkflowJobStepsStatus.Queued,
                _ => null,
            };
        }
    }
}