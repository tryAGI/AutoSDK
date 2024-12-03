//HintName: G.Models.WebhooksRuleAllowDeletionsEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleAllowDeletionsEnforcementLevel
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
        public static WebhooksRuleAllowDeletionsEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRuleAllowDeletionsEnforcementLevel.Off,
                "non_admins" => WebhooksRuleAllowDeletionsEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleAllowDeletionsEnforcementLevel.Everyone,
                _ => null,
            };
        }
    }
}