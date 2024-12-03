//HintName: G.Models.WebhookSecretScanningAlertReopenedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookSecretScanningAlertReopenedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reopened")]
        Reopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertReopenedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertReopenedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertReopenedAction.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertReopenedAction? ToEnum(string value)
        {
            return value switch
            {
                "reopened" => WebhookSecretScanningAlertReopenedAction.Reopened,
                _ => null,
            };
        }
    }
}