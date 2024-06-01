//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom
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