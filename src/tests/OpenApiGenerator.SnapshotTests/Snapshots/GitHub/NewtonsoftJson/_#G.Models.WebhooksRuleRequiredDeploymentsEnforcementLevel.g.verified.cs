//HintName: G.Models.WebhooksRuleRequiredDeploymentsEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleRequiredDeploymentsEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_admins")]
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everyone")]
        Everyone,
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
                WebhooksRuleRequiredDeploymentsEnforcementLevel.Off => "off",
                WebhooksRuleRequiredDeploymentsEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleRequiredDeploymentsEnforcementLevel.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleRequiredDeploymentsEnforcementLevel ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRuleRequiredDeploymentsEnforcementLevel.Off,
                "non_admins" => WebhooksRuleRequiredDeploymentsEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleRequiredDeploymentsEnforcementLevel.Everyone,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}