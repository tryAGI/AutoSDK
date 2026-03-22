//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunCompletedWorkflowRunStatus
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
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunCompletedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunStatus.Completed => "completed",
                WebhookWorkflowRunCompletedWorkflowRunStatus.InProgress => "in_progress",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Pending => "pending",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Queued => "queued",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Requested => "requested",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowRunCompletedWorkflowRunStatus.Completed,
                "in_progress" => WebhookWorkflowRunCompletedWorkflowRunStatus.InProgress,
                "pending" => WebhookWorkflowRunCompletedWorkflowRunStatus.Pending,
                "queued" => WebhookWorkflowRunCompletedWorkflowRunStatus.Queued,
                "requested" => WebhookWorkflowRunCompletedWorkflowRunStatus.Requested,
                "waiting" => WebhookWorkflowRunCompletedWorkflowRunStatus.Waiting,
                _ => null,
            };
        }
    }
}