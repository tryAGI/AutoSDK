//HintName: G.Models.WebhooksRuleLinearHistoryRequirementEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleLinearHistoryRequirementEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everyone")]
        Everyone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_admins")]
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksRuleLinearHistoryRequirementEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleLinearHistoryRequirementEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleLinearHistoryRequirementEnforcementLevel.Everyone => "everyone",
                WebhooksRuleLinearHistoryRequirementEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleLinearHistoryRequirementEnforcementLevel.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleLinearHistoryRequirementEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhooksRuleLinearHistoryRequirementEnforcementLevel.Everyone,
                "non_admins" => WebhooksRuleLinearHistoryRequirementEnforcementLevel.NonAdmins,
                "off" => WebhooksRuleLinearHistoryRequirementEnforcementLevel.Off,
                _ => null,
            };
        }
    }
}