//HintName: G.Models.SecretScanningAlertWebhookResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for resolving the alert.
    /// </summary>
    public abstract class SecretScanningAlertWebhookResolution
    {
        /// <summary>
        /// 
        /// </summary>
        public const string FalsePositive = "false_positive";
        /// <summary>
        /// 
        /// </summary>
        public const string WontFix = "wont_fix";
        /// <summary>
        /// 
        /// </summary>
        public const string Revoked = "revoked";
        /// <summary>
        /// 
        /// </summary>
        public const string UsedInTests = "used_in_tests";
        /// <summary>
        /// 
        /// </summary>
        public const string PatternDeleted = "pattern_deleted";
        /// <summary>
        /// 
        /// </summary>
        public const string PatternEdited = "pattern_edited";
    }
}