//HintName: G.Models.WebhookCodeScanningAlertFixedAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertFixedAlertRuleSeverity
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
    public static class WebhookCodeScanningAlertFixedAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertFixedAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertFixedAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertFixedAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertFixedAlertRuleSeverity.Warning => "warning",
                WebhookCodeScanningAlertFixedAlertRuleSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertFixedAlertRuleSeverity ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertFixedAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertFixedAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertFixedAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertFixedAlertRuleSeverity.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}