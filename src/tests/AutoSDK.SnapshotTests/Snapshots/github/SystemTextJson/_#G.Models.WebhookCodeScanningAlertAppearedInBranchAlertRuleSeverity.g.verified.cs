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
    public static class WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Error => "error",
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Warning => "warning",
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
                "error" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Error,
                "none" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Note,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "warning" => WebhookCodeScanningAlertAppearedInBranchAlertRuleSeverity.Warning,
                _ => null,
            };
        }
    }
}