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
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertCreatedAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "none" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Note,
                "warning" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Warning,
                "error" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Error,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}