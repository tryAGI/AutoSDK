//HintName: G.Models.WebhooksRuleSignatureRequirementEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRuleSignatureRequirementEnforcementLevel
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
    public static class WebhooksRuleSignatureRequirementEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleSignatureRequirementEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleSignatureRequirementEnforcementLevel.Everyone => "everyone",
                WebhooksRuleSignatureRequirementEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleSignatureRequirementEnforcementLevel.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleSignatureRequirementEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhooksRuleSignatureRequirementEnforcementLevel.Everyone,
                "non_admins" => WebhooksRuleSignatureRequirementEnforcementLevel.NonAdmins,
                "off" => WebhooksRuleSignatureRequirementEnforcementLevel.Off,
                _ => null,
            };
        }
    }
}