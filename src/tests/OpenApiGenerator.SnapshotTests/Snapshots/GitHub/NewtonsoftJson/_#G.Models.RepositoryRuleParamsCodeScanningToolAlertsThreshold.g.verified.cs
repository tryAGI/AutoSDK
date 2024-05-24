//HintName: G.Models.RepositoryRuleParamsCodeScanningToolAlertsThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity level at which code scanning results that raise alerts block a reference update. For more information on alert severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleParamsCodeScanningToolAlertsThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="errors")]
        Errors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="errors_and_warnings")]
        ErrorsAndWarnings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }
}