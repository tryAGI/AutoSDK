//HintName: G.Models.WebhooksRuleLinearHistoryRequirementEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksRuleLinearHistoryRequirementEnforcementLevel
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
    public static class WebhooksRuleLinearHistoryRequirementEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleLinearHistoryRequirementEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleLinearHistoryRequirementEnforcementLevel.Off => "off",
                WebhooksRuleLinearHistoryRequirementEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleLinearHistoryRequirementEnforcementLevel.Everyone => "everyone",
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
                "off" => WebhooksRuleLinearHistoryRequirementEnforcementLevel.Off,
                "non_admins" => WebhooksRuleLinearHistoryRequirementEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleLinearHistoryRequirementEnforcementLevel.Everyone,
                _ => null,
            };
        }
    }
}