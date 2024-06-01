//HintName: G.Models.WebhooksRuleAllowForcePushesEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleAllowForcePushesEnforcementLevel
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
    public static class WebhooksRuleAllowForcePushesEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleAllowForcePushesEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleAllowForcePushesEnforcementLevel.Off => "off",
                WebhooksRuleAllowForcePushesEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleAllowForcePushesEnforcementLevel.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleAllowForcePushesEnforcementLevel ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRuleAllowForcePushesEnforcementLevel.Off,
                "non_admins" => WebhooksRuleAllowForcePushesEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleAllowForcePushesEnforcementLevel.Everyone,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}