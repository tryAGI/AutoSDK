//HintName: G.Models.RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
    /// </summary>
    public abstract class RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
        /// <summary>
        /// 
        /// </summary>
        public const string Critical = "critical";
        /// <summary>
        /// 
        /// </summary>
        public const string HighOrHigher = "high_or_higher";
        /// <summary>
        /// 
        /// </summary>
        public const string MediumOrHigher = "medium_or_higher";
        /// <summary>
        /// 
        /// </summary>
        public const string All = "all";
    }
}