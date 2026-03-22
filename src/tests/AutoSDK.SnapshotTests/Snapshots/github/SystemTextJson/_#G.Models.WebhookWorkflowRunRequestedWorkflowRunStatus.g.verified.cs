//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunRequestedWorkflowRunStatus
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
    public static class WebhookWorkflowRunRequestedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunStatus.Completed => "completed",
                WebhookWorkflowRunRequestedWorkflowRunStatus.InProgress => "in_progress",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Pending => "pending",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Queued => "queued",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Requested => "requested",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowRunRequestedWorkflowRunStatus.Completed,
                "in_progress" => WebhookWorkflowRunRequestedWorkflowRunStatus.InProgress,
                "pending" => WebhookWorkflowRunRequestedWorkflowRunStatus.Pending,
                "queued" => WebhookWorkflowRunRequestedWorkflowRunStatus.Queued,
                "requested" => WebhookWorkflowRunRequestedWorkflowRunStatus.Requested,
                "waiting" => WebhookWorkflowRunRequestedWorkflowRunStatus.Waiting,
                _ => null,
            };
        }
    }
}