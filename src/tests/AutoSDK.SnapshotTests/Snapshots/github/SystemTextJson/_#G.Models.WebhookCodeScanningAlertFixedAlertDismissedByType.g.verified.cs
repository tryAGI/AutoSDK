//HintName: G.Models.WebhookCodeScanningAlertFixedAlertDismissedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCodeScanningAlertFixedAlertDismissedByType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertFixedAlertDismissedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertFixedAlertDismissedByType value)
        {
            return value switch
            {
                WebhookCodeScanningAlertFixedAlertDismissedByType.Bot => "Bot",
                WebhookCodeScanningAlertFixedAlertDismissedByType.Organization => "Organization",
                WebhookCodeScanningAlertFixedAlertDismissedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertFixedAlertDismissedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCodeScanningAlertFixedAlertDismissedByType.Bot,
                "Organization" => WebhookCodeScanningAlertFixedAlertDismissedByType.Organization,
                "User" => WebhookCodeScanningAlertFixedAlertDismissedByType.User,
                _ => null,
            };
        }
    }
}