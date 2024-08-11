//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.Completed => "completed",
                WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.Pending => "pending",
                WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.Completed,
                "pending" => WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.Pending,
                "queued" => WebhookWorkflowJobInProgressWorkflowJobVariant2StepStatus.Queued,
                _ => null,
            };
        }
    }
}