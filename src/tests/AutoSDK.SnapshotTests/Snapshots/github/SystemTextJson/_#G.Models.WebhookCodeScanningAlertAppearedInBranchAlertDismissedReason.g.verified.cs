//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for dismissing or closing the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        UsedInTests,
        /// <summary>
        /// 
        /// </summary>
        WontFix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertAppearedInBranchAlertDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.FalsePositive => "false positive",
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.UsedInTests => "used in tests",
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.WontFix => "won't fix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "false positive" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.FalsePositive,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "used in tests" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.UsedInTests,
                "won't fix" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.WontFix,
                _ => null,
            };
        }
    }
}