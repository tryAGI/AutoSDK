//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobQueuedWorkflowJobStepsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobQueuedWorkflowJobStepsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedWorkflowJobStepsStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedWorkflowJobStepsStatus.Completed => "completed",
                WebhookWorkflowJobQueuedWorkflowJobStepsStatus.InProgress => "in_progress",
                WebhookWorkflowJobQueuedWorkflowJobStepsStatus.Queued => "queued",
                WebhookWorkflowJobQueuedWorkflowJobStepsStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedWorkflowJobStepsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobQueuedWorkflowJobStepsStatus.Completed,
                "in_progress" => WebhookWorkflowJobQueuedWorkflowJobStepsStatus.InProgress,
                "queued" => WebhookWorkflowJobQueuedWorkflowJobStepsStatus.Queued,
                "pending" => WebhookWorkflowJobQueuedWorkflowJobStepsStatus.Pending,
                _ => null,
            };
        }
    }
}