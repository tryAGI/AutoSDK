//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedByUserAction
    {
        /// <summary>
        /// 
        /// </summary>
        ReopenedByUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertReopenedByUserActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedByUserAction value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedByUserAction.ReopenedByUser => "reopened_by_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedByUserAction ToEnum(string value)
        {
            return value switch
            {
                "reopened_by_user" => WebhookCodeScanningAlertReopenedByUserAction.ReopenedByUser,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}