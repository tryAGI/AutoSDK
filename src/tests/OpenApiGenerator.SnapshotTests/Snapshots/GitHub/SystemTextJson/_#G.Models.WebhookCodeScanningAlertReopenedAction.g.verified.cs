//HintName: G.Models.WebhookCodeScanningAlertReopenedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Reopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertReopenedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedAction value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedAction.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedAction ToEnum(string value)
        {
            return value switch
            {
                "reopened" => WebhookCodeScanningAlertReopenedAction.Reopened,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}