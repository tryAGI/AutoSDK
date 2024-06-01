//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom
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
    public static class WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.Off => "off",
                WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.NonAdmins => "non_admins",
                WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.Off,
                "non_admins" => WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.NonAdmins,
                "everyone" => WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.Everyone,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}