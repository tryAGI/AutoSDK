//HintName: G.Models.WebhookCodeScanningAlertCreatedAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertCreatedAlertRuleSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Note,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertCreatedAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertCreatedAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.Warning => "warning",
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertCreatedAlertRuleSeverity ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}