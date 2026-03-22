//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobWaitingWorkflowJobStepStatus
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
        Pending,
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
    public static class WebhookWorkflowJobWaitingWorkflowJobStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Completed => "completed",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.InProgress => "in_progress",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Pending => "pending",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Queued => "queued",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Completed,
                "in_progress" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.InProgress,
                "pending" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Pending,
                "queued" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Queued,
                "waiting" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Waiting,
                _ => null,
            };
        }
    }
}