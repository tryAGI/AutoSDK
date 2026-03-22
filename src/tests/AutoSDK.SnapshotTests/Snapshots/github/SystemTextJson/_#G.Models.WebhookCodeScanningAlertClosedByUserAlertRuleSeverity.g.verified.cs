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
        Error,
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
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Warning,
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
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Error => "error",
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Warning => "warning",
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
                "error" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Error,
                "none" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Note,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "warning" => WebhookCodeScanningAlertClosedByUserAlertRuleSeverity.Warning,
                _ => null,
            };
        }
    }
}