//HintName: G.Models.WebhookDependabotAlertAutoDismissedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDependabotAlertAutoDismissedAction
    {
        /// <summary>
        /// 
        /// </summary>
        AutoDismissed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDependabotAlertAutoDismissedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDependabotAlertAutoDismissedAction value)
        {
            return value switch
            {
                WebhookDependabotAlertAutoDismissedAction.AutoDismissed => "auto_dismissed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDependabotAlertAutoDismissedAction? ToEnum(string value)
        {
            return value switch
            {
                "auto_dismissed" => WebhookDependabotAlertAutoDismissedAction.AutoDismissed,
                _ => null,
            };
        }
    }
}