//HintName: G.Models.WebhookDependabotAlertAutoReopenedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDependabotAlertAutoReopenedAction
    {
        /// <summary>
        /// 
        /// </summary>
        AutoReopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDependabotAlertAutoReopenedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDependabotAlertAutoReopenedAction value)
        {
            return value switch
            {
                WebhookDependabotAlertAutoReopenedAction.AutoReopened => "auto_reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDependabotAlertAutoReopenedAction ToEnum(string value)
        {
            return value switch
            {
                "auto_reopened" => WebhookDependabotAlertAutoReopenedAction.AutoReopened,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}