//HintName: G.Models.RepositoryRuleParamsCodeScanningToolAlertsThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity level at which code scanning results that raise alerts block a reference update. For more information on alert severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
    /// </summary>
    public enum RepositoryRuleParamsCodeScanningToolAlertsThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Errors,
        /// <summary>
        /// 
        /// </summary>
        ErrorsAndWarnings,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleParamsCodeScanningToolAlertsThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleParamsCodeScanningToolAlertsThreshold value)
        {
            return value switch
            {
                RepositoryRuleParamsCodeScanningToolAlertsThreshold.None => "none",
                RepositoryRuleParamsCodeScanningToolAlertsThreshold.Errors => "errors",
                RepositoryRuleParamsCodeScanningToolAlertsThreshold.ErrorsAndWarnings => "errors_and_warnings",
                RepositoryRuleParamsCodeScanningToolAlertsThreshold.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleParamsCodeScanningToolAlertsThreshold ToEnum(string value)
        {
            return value switch
            {
                "none" => RepositoryRuleParamsCodeScanningToolAlertsThreshold.None,
                "errors" => RepositoryRuleParamsCodeScanningToolAlertsThreshold.Errors,
                "errors_and_warnings" => RepositoryRuleParamsCodeScanningToolAlertsThreshold.ErrorsAndWarnings,
                "all" => RepositoryRuleParamsCodeScanningToolAlertsThreshold.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}