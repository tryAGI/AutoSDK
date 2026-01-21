//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertClosedByUserAlertRuleSeverity
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
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}