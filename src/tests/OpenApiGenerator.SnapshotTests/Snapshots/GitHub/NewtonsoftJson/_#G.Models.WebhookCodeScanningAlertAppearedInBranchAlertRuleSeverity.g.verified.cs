//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="note")]
        Note,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
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
        public static WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Error,
                _ => null,
            };
        }
    }
}