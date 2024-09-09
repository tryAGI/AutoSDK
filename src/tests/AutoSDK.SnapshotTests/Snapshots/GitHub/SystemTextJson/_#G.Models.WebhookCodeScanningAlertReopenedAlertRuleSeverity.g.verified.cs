//HintName: G.Models.WebhookCodeScanningAlertReopenedAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedAlertRuleSeverity
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
    public static class WebhookCodeScanningAlertReopenedAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertReopenedAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertReopenedAlertRuleSeverity.Warning => "warning",
                WebhookCodeScanningAlertReopenedAlertRuleSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertReopenedAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertReopenedAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertReopenedAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertReopenedAlertRuleSeverity.Error,
                _ => null,
            };
        }
    }
}