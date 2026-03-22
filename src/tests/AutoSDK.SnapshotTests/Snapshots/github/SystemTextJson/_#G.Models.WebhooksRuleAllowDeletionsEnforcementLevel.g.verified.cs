//HintName: G.Models.WebhooksRuleAllowDeletionsEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRuleAllowDeletionsEnforcementLevel
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
    public static class WebhooksRuleAllowDeletionsEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleAllowDeletionsEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleAllowDeletionsEnforcementLevel.Everyone => "everyone",
                WebhooksRuleAllowDeletionsEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleAllowDeletionsEnforcementLevel.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleAllowDeletionsEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhooksRuleAllowDeletionsEnforcementLevel.Everyone,
                "non_admins" => WebhooksRuleAllowDeletionsEnforcementLevel.NonAdmins,
                "off" => WebhooksRuleAllowDeletionsEnforcementLevel.Off,
                _ => null,
            };
        }
    }
}