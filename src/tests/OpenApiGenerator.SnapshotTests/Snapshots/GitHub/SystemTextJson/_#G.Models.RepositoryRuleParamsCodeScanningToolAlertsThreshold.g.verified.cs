//HintName: G.Models.RepositoryRuleParamsCodeScanningToolAlertsThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity level at which code scanning results that raise alerts block a reference update. For more information on alert severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
    /// </summary>
    public abstract class RepositoryRuleParamsCodeScanningToolAlertsThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
        /// <summary>
        /// 
        /// </summary>
        public const string Errors = "errors";
        /// <summary>
        /// 
        /// </summary>
        public const string ErrorsAndWarnings = "errors_and_warnings";
        /// <summary>
        /// 
        /// </summary>
        public const string All = "all";
    }
}