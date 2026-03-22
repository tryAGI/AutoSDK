//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, or `completed`.
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Completed => "completed",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Completed,
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.InProgress,
                "queued" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Queued,
                _ => null,
            };
        }
    }
}