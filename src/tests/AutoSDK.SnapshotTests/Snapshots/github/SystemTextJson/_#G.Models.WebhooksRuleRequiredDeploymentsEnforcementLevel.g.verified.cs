//HintName: G.Models.WebhooksRuleRequiredDeploymentsEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRuleRequiredDeploymentsEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Everyone,
        /// <summary>
        /// 
        /// </summary>
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksRuleRequiredDeploymentsEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleRequiredDeploymentsEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleRequiredDeploymentsEnforcementLevel.Everyone => "everyone",
                WebhooksRuleRequiredDeploymentsEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleRequiredDeploymentsEnforcementLevel.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleRequiredDeploymentsEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhooksRuleRequiredDeploymentsEnforcementLevel.Everyone,
                "non_admins" => WebhooksRuleRequiredDeploymentsEnforcementLevel.NonAdmins,
                "off" => WebhooksRuleRequiredDeploymentsEnforcementLevel.Off,
                _ => null,
            };
        }
    }
}