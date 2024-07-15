//HintName: G.Models.WebhooksRuleRequiredStatusChecksEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleRequiredStatusChecksEnforcementLevel
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
    public static class WebhooksRuleRequiredStatusChecksEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleRequiredStatusChecksEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleRequiredStatusChecksEnforcementLevel.Off => "off",
                WebhooksRuleRequiredStatusChecksEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleRequiredStatusChecksEnforcementLevel.Everyone => "everyone",
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
                "off" => WebhooksRuleRequiredStatusChecksEnforcementLevel.Off,
                "non_admins" => WebhooksRuleRequiredStatusChecksEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleRequiredStatusChecksEnforcementLevel.Everyone,
                _ => null,
            };
        }
    }
}