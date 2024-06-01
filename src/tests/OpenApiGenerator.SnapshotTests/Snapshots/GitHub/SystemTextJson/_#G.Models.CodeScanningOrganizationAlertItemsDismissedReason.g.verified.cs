//HintName: G.Models.CodeScanningOrganizationAlertItemsDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
    /// </summary>
    public enum CodeScanningOrganizationAlertItemsDismissedReason
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
    public static class CodeScanningOrganizationAlertItemsDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningOrganizationAlertItemsDismissedReason value)
        {
            return value switch
            {
                CodeScanningOrganizationAlertItemsDismissedReason.FalsePositive => "false positive",
                CodeScanningOrganizationAlertItemsDismissedReason.WontFix => "won't fix",
                CodeScanningOrganizationAlertItemsDismissedReason.UsedInTests => "used in tests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningOrganizationAlertItemsDismissedReason ToEnum(string value)
        {
            return value switch
            {
                "false positive" => CodeScanningOrganizationAlertItemsDismissedReason.FalsePositive,
                "won't fix" => CodeScanningOrganizationAlertItemsDismissedReason.WontFix,
                "used in tests" => CodeScanningOrganizationAlertItemsDismissedReason.UsedInTests,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}