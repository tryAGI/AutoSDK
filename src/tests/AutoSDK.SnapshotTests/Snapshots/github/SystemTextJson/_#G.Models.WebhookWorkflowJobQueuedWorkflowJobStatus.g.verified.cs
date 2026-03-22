//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobQueuedWorkflowJobStatus
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
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobQueuedWorkflowJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedWorkflowJobStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedWorkflowJobStatus.Completed => "completed",
                WebhookWorkflowJobQueuedWorkflowJobStatus.InProgress => "in_progress",
                WebhookWorkflowJobQueuedWorkflowJobStatus.Queued => "queued",
                WebhookWorkflowJobQueuedWorkflowJobStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedWorkflowJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobQueuedWorkflowJobStatus.Completed,
                "in_progress" => WebhookWorkflowJobQueuedWorkflowJobStatus.InProgress,
                "queued" => WebhookWorkflowJobQueuedWorkflowJobStatus.Queued,
                "waiting" => WebhookWorkflowJobQueuedWorkflowJobStatus.Waiting,
                _ => null,
            };
        }
    }
}