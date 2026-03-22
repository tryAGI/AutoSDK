//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for dismissing or closing the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertClosedByUserAlertDismissedReason
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
    public static class WebhookCodeScanningAlertClosedByUserAlertDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertClosedByUserAlertDismissedReason value)
        {
            return value switch
            {
                WebhookCodeScanningAlertClosedByUserAlertDismissedReason.FalsePositive => "false positive",
                WebhookCodeScanningAlertClosedByUserAlertDismissedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertClosedByUserAlertDismissedReason.UsedInTests => "used in tests",
                WebhookCodeScanningAlertClosedByUserAlertDismissedReason.WontFix => "won't fix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertClosedByUserAlertDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "false positive" => WebhookCodeScanningAlertClosedByUserAlertDismissedReason.FalsePositive,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertClosedByUserAlertDismissedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "used in tests" => WebhookCodeScanningAlertClosedByUserAlertDismissedReason.UsedInTests,
                "won't fix" => WebhookCodeScanningAlertClosedByUserAlertDismissedReason.WontFix,
                _ => null,
            };
        }
    }
}