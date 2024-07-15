//HintName: G.Models.WebhookWorkflowJobWaitingAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobWaitingAction
    {
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobWaitingActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingAction value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingAction.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingAction? ToEnum(string value)
        {
            return value switch
            {
                "waiting" => WebhookWorkflowJobWaitingAction.Waiting,
                _ => null,
            };
        }
    }
}