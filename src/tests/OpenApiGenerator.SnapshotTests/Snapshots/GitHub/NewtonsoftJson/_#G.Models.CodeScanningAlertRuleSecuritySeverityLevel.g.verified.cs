//HintName: G.Models.CodeScanningAlertRuleSecuritySeverityLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The security severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertRuleSecuritySeverityLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
    }
}