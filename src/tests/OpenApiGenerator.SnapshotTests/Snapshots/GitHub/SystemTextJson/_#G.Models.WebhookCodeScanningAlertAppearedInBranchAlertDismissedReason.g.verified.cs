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
        WontFix,
        /// <summary>
        /// 
        /// </summary>
        UsedInTests,
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
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.WontFix => "won't fix",
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.UsedInTests => "used in tests",
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
                "won't fix" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.WontFix,
                "used in tests" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedReason.UsedInTests,
                _ => null,
            };
        }
    }
}