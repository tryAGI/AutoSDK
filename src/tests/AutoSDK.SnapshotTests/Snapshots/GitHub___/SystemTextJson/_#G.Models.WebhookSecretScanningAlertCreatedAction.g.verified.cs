//HintName: G.Models.WebhookSecretScanningAlertCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecretScanningAlertCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertCreatedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertCreatedAction? ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookSecretScanningAlertCreatedAction.Created,
                _ => null,
            };
        }
    }
}