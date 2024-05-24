//HintName: G.Models.OrganizationSecretScanningAlertResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
    /// </summary>
    public abstract class OrganizationSecretScanningAlertResolution
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
    }
}