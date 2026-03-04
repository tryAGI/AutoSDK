//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus
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
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Completed => "completed",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Queued => "queued",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Completed,
                "queued" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Queued,
                "pending" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Pending,
                _ => null,
            };
        }
    }
}