//HintName: G.Models.CodeScanningOrganizationAlertItemsDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
    /// </summary>
    public abstract class CodeScanningOrganizationAlertItemsDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string FalsePositive = "false positive";
        /// <summary>
        /// 
        /// </summary>
        public const string WontFix = "won't fix";
        /// <summary>
        /// 
        /// </summary>
        public const string UsedInTests = "used in tests";
    }
}