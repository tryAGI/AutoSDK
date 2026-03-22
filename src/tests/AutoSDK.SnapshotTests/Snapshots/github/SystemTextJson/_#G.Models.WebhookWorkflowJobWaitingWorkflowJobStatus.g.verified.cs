//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobWaitingWorkflowJobStatus
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
    public static class WebhookWorkflowJobWaitingWorkflowJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStatus.Completed => "completed",
                WebhookWorkflowJobWaitingWorkflowJobStatus.InProgress => "in_progress",
                WebhookWorkflowJobWaitingWorkflowJobStatus.Queued => "queued",
                WebhookWorkflowJobWaitingWorkflowJobStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobWaitingWorkflowJobStatus.Completed,
                "in_progress" => WebhookWorkflowJobWaitingWorkflowJobStatus.InProgress,
                "queued" => WebhookWorkflowJobWaitingWorkflowJobStatus.Queued,
                "waiting" => WebhookWorkflowJobWaitingWorkflowJobStatus.Waiting,
                _ => null,
            };
        }
    }
}