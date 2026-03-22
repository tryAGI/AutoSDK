//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunInProgressWorkflowRunStatus
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
        Requested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunInProgressWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunStatus.Completed => "completed",
                WebhookWorkflowRunInProgressWorkflowRunStatus.InProgress => "in_progress",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Pending => "pending",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Queued => "queued",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowRunInProgressWorkflowRunStatus.Completed,
                "in_progress" => WebhookWorkflowRunInProgressWorkflowRunStatus.InProgress,
                "pending" => WebhookWorkflowRunInProgressWorkflowRunStatus.Pending,
                "queued" => WebhookWorkflowRunInProgressWorkflowRunStatus.Queued,
                "requested" => WebhookWorkflowRunInProgressWorkflowRunStatus.Requested,
                _ => null,
            };
        }
    }
}