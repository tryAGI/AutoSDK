//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity
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
    public static class WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Warning => "warning",
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}