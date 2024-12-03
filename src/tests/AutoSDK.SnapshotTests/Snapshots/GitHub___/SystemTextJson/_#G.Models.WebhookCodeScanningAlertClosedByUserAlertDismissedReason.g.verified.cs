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
        WontFix,
        /// <summary>
        /// 
        /// </summary>
        UsedInTests,
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
                WebhookCodeScanningAlertClosedByUserAlertDismissedReason.WontFix => "won't fix",
                WebhookCodeScanningAlertClosedByUserAlertDismissedReason.UsedInTests => "used in tests",
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
                "won't fix" => WebhookCodeScanningAlertClosedByUserAlertDismissedReason.WontFix,
                "used in tests" => WebhookCodeScanningAlertClosedByUserAlertDismissedReason.UsedInTests,
                _ => null,
            };
        }
    }
}