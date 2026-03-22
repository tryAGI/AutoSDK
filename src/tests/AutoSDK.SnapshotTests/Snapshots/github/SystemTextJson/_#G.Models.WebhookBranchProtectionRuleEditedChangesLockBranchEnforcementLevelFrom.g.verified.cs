//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom
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
    public static class WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom.Everyone => "everyone",
                WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom.NonAdmins => "non_admins",
                WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom.Everyone,
                "non_admins" => WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom.NonAdmins,
                "off" => WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom.Off,
                _ => null,
            };
        }
    }
}