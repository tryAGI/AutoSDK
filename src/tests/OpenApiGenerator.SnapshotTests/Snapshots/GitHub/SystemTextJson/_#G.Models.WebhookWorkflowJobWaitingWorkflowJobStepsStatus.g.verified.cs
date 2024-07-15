//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobWaitingWorkflowJobStepsStatus
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
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobWaitingWorkflowJobStepsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStepsStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Completed => "completed",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.InProgress => "in_progress",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Queued => "queued",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Pending => "pending",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStepsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Completed,
                "in_progress" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.InProgress,
                "queued" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Queued,
                "pending" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Pending,
                "waiting" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Waiting,
                _ => null,
            };
        }
    }
}