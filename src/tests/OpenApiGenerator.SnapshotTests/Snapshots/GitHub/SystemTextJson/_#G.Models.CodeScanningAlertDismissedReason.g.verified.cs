//HintName: G.Models.CodeScanningAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
    /// </summary>
    public enum CodeScanningAlertDismissedReason
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
    public static class CodeScanningAlertDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertDismissedReason value)
        {
            return value switch
            {
                CodeScanningAlertDismissedReason.FalsePositive => "false positive",
                CodeScanningAlertDismissedReason.WontFix => "won't fix",
                CodeScanningAlertDismissedReason.UsedInTests => "used in tests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "false positive" => CodeScanningAlertDismissedReason.FalsePositive,
                "won't fix" => CodeScanningAlertDismissedReason.WontFix,
                "used in tests" => CodeScanningAlertDismissedReason.UsedInTests,
                _ => null,
            };
        }
    }
}