//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity
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
    public static class WebhookCodeScanningAlertReopenedByUserAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Warning => "warning",
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}