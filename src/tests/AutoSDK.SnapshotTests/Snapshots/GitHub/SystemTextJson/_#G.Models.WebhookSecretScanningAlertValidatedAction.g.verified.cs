//HintName: G.Models.WebhookSecretScanningAlertValidatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecretScanningAlertValidatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Validated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertValidatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertValidatedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertValidatedAction.Validated => "validated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertValidatedAction? ToEnum(string value)
        {
            return value switch
            {
                "validated" => WebhookSecretScanningAlertValidatedAction.Validated,
                _ => null,
            };
        }
    }
}