//HintName: G.Models.DependabotAlertSecurityAdvisorySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertSecurityAdvisorySeverity
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