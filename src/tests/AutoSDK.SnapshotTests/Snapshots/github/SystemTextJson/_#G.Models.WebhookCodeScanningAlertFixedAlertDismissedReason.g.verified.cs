//HintName: G.Models.WebhookCodeScanningAlertFixedAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for dismissing or closing the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertFixedAlertDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        WontFix,
        /// <summary>
        /// 
        /// </summary>
        UsedInTests,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertFixedAlertDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertFixedAlertDismissedReason value)
        {
            return value switch
            {
                WebhookCodeScanningAlertFixedAlertDismissedReason.FalsePositive => "false positive",
                WebhookCodeScanningAlertFixedAlertDismissedReason.WontFix => "won't fix",
                WebhookCodeScanningAlertFixedAlertDismissedReason.UsedInTests => "used in tests",
                WebhookCodeScanningAlertFixedAlertDismissedReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertFixedAlertDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "false positive" => WebhookCodeScanningAlertFixedAlertDismissedReason.FalsePositive,
                "won't fix" => WebhookCodeScanningAlertFixedAlertDismissedReason.WontFix,
                "used in tests" => WebhookCodeScanningAlertFixedAlertDismissedReason.UsedInTests,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertFixedAlertDismissedReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}