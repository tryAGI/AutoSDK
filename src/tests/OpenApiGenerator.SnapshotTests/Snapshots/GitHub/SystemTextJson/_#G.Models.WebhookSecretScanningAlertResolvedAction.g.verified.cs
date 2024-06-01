//HintName: G.Models.WebhookSecretScanningAlertResolvedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecretScanningAlertResolvedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertResolvedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertResolvedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertResolvedAction.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertResolvedAction ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookSecretScanningAlertResolvedAction.Resolved,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}