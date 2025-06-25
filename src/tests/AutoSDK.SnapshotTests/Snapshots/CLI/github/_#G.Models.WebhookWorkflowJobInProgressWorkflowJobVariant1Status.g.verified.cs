//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, or `completed`.
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobVariant1Status value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobVariant1Status.Queued => "queued",
                WebhookWorkflowJobInProgressWorkflowJobVariant1Status.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobVariant1Status.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobInProgressWorkflowJobVariant1Status.Queued,
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobVariant1Status.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobVariant1Status.Completed,
                _ => null,
            };
        }
    }
}