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
        Off,
        /// <summary>
        /// 
        /// </summary>
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        Everyone,
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
                WebhooksRuleAllowDeletionsEnforcementLevel.Off => "off",
                WebhooksRuleAllowDeletionsEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleAllowDeletionsEnforcementLevel.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleAllowDeletionsEnforcementLevel ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRuleAllowDeletionsEnforcementLevel.Off,
                "non_admins" => WebhooksRuleAllowDeletionsEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleAllowDeletionsEnforcementLevel.Everyone,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}