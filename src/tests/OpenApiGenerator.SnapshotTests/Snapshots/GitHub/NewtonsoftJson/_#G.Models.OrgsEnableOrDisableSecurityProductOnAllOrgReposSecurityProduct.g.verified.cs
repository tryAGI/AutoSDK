//HintName: G.Models.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dependency_graph")]
        DependencyGraph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dependabot_alerts")]
        DependabotAlerts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dependabot_security_updates")]
        DependabotSecurityUpdates,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="advanced_security")]
        AdvancedSecurity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_scanning_default_setup")]
        CodeScanningDefaultSetup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning")]
        SecretScanning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_push_protection")]
        SecretScanningPushProtection,
    }
}