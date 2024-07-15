//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertClosedByUserAlertRuleSeverity
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
    public static class WebhookCodeScanningAlertClosedByUserAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertClosedByUserAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Warning => "warning",
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertClosedByUserAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Error,
                _ => null,
            };
        }
    }
}