//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity
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
    public static class WebhookCodeScanningAlertReopenedByUserAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Error => "error",
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Error,
                "none" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Note,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "warning" => WebhookCodeScanningAlertReopenedByUserAlertRuleSeverity.Warning,
                _ => null,
            };
        }
    }
}