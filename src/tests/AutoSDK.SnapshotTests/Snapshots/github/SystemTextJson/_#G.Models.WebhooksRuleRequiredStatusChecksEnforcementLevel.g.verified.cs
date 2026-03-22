//HintName: G.Models.WebhooksRuleRequiredStatusChecksEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRuleRequiredStatusChecksEnforcementLevel
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
    public static class WebhooksRuleRequiredStatusChecksEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleRequiredStatusChecksEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleRequiredStatusChecksEnforcementLevel.Everyone => "everyone",
                WebhooksRuleRequiredStatusChecksEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleRequiredStatusChecksEnforcementLevel.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleRequiredStatusChecksEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhooksRuleRequiredStatusChecksEnforcementLevel.Everyone,
                "non_admins" => WebhooksRuleRequiredStatusChecksEnforcementLevel.NonAdmins,
                "off" => WebhooksRuleRequiredStatusChecksEnforcementLevel.Off,
                _ => null,
            };
        }
    }
}