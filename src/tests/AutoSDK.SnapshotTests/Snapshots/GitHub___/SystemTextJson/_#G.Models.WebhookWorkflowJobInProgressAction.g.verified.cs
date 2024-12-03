//HintName: G.Models.WebhookWorkflowJobInProgressAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressAction
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressAction value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressAction.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressAction? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobInProgressAction.InProgress,
                _ => null,
            };
        }
    }
}