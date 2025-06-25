//HintName: G.Models.WebhookWorkflowJobQueuedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobQueuedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobQueuedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedAction value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedAction.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedAction? ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobQueuedAction.Queued,
                _ => null,
            };
        }
    }
}