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
        Requested,
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
                WebhookWorkflowRunCompletedWorkflowRunStatus.Requested => "requested",
                WebhookWorkflowRunCompletedWorkflowRunStatus.InProgress => "in_progress",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Completed => "completed",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Queued => "queued",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Pending => "pending",
                WebhookWorkflowRunCompletedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunStatus ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookWorkflowRunCompletedWorkflowRunStatus.Requested,
                "in_progress" => WebhookWorkflowRunCompletedWorkflowRunStatus.InProgress,
                "completed" => WebhookWorkflowRunCompletedWorkflowRunStatus.Completed,
                "queued" => WebhookWorkflowRunCompletedWorkflowRunStatus.Queued,
                "pending" => WebhookWorkflowRunCompletedWorkflowRunStatus.Pending,
                "waiting" => WebhookWorkflowRunCompletedWorkflowRunStatus.Waiting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}