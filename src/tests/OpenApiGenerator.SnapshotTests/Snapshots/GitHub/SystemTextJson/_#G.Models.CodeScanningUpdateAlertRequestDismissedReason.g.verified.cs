//HintName: G.Models.CodeScanningUpdateAlertRequestDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
    /// </summary>
    public enum CodeScanningUpdateAlertRequestDismissedReason
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
    public static class CodeScanningUpdateAlertRequestDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningUpdateAlertRequestDismissedReason value)
        {
            return value switch
            {
                CodeScanningUpdateAlertRequestDismissedReason.FalsePositive => "false positive",
                CodeScanningUpdateAlertRequestDismissedReason.WontFix => "won't fix",
                CodeScanningUpdateAlertRequestDismissedReason.UsedInTests => "used in tests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningUpdateAlertRequestDismissedReason ToEnum(string value)
        {
            return value switch
            {
                "false positive" => CodeScanningUpdateAlertRequestDismissedReason.FalsePositive,
                "won't fix" => CodeScanningUpdateAlertRequestDismissedReason.WontFix,
                "used in tests" => CodeScanningUpdateAlertRequestDismissedReason.UsedInTests,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}