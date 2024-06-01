//HintName: G.Models.WebhookSecretScanningAlertRevokedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecretScanningAlertRevokedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertRevokedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertRevokedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertRevokedAction.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertRevokedAction ToEnum(string value)
        {
            return value switch
            {
                "revoked" => WebhookSecretScanningAlertRevokedAction.Revoked,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}