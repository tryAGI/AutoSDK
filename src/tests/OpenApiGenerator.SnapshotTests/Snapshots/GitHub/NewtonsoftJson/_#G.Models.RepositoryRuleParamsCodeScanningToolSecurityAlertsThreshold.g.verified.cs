//HintName: G.Models.RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleParamsCodeScanningToolSecurityAlertsThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high_or_higher")]
        HighOrHigher,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium_or_higher")]
        MediumOrHigher,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }
}