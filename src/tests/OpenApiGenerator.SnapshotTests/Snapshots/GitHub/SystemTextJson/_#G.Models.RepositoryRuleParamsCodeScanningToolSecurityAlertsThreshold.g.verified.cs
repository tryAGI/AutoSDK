//HintName: G.Models.RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
    /// </summary>
    public enum RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        HighOrHigher,
        /// <summary>
        /// 
        /// </summary>
        MediumOrHigher,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleParamsCodeScanningToolSecurityAlertsThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold value)
        {
            return value switch
            {
                RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.None => "none",
                RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.Critical => "critical",
                RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.HighOrHigher => "high_or_higher",
                RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.MediumOrHigher => "medium_or_higher",
                RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold ToEnum(string value)
        {
            return value switch
            {
                "none" => RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.None,
                "critical" => RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.Critical,
                "high_or_higher" => RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.HighOrHigher,
                "medium_or_higher" => RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.MediumOrHigher,
                "all" => RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}