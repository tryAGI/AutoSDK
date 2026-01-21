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
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}