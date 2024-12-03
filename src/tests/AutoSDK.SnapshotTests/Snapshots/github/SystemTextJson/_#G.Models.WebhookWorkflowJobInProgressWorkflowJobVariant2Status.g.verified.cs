//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobVariant2Status
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobVariant2Status value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobVariant2Status.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobVariant2Status.Completed => "completed",
                WebhookWorkflowJobInProgressWorkflowJobVariant2Status.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobVariant2Status.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobVariant2Status.Completed,
                "queued" => WebhookWorkflowJobInProgressWorkflowJobVariant2Status.Queued,
                _ => null,
            };
        }
    }
}