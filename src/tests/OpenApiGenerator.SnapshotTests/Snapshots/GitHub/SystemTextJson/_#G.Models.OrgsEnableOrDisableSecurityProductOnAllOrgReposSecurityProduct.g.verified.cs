//HintName: G.Models.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct
    {
        /// <summary>
        /// 
        /// </summary>
        DependencyGraph,
        /// <summary>
        /// 
        /// </summary>
        DependabotAlerts,
        /// <summary>
        /// 
        /// </summary>
        DependabotSecurityUpdates,
        /// <summary>
        /// 
        /// </summary>
        AdvancedSecurity,
        /// <summary>
        /// 
        /// </summary>
        CodeScanningDefaultSetup,
        /// <summary>
        /// 
        /// </summary>
        SecretScanning,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningPushProtection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct value)
        {
            return value switch
            {
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependencyGraph => "dependency_graph",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotAlerts => "dependabot_alerts",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotSecurityUpdates => "dependabot_security_updates",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.AdvancedSecurity => "advanced_security",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.CodeScanningDefaultSetup => "code_scanning_default_setup",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanning => "secret_scanning",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanningPushProtection => "secret_scanning_push_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct? ToEnum(string value)
        {
            return value switch
            {
                "dependency_graph" => OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependencyGraph,
                "dependabot_alerts" => OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotAlerts,
                "dependabot_security_updates" => OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotSecurityUpdates,
                "advanced_security" => OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.AdvancedSecurity,
                "code_scanning_default_setup" => OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.CodeScanningDefaultSetup,
                "secret_scanning" => OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanning,
                "secret_scanning_push_protection" => OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanningPushProtection,
                _ => null,
            };
        }
    }
}