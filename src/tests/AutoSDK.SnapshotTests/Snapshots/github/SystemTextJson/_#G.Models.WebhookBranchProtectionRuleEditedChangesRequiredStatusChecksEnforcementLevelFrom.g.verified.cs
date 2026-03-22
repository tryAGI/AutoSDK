//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom
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
    public static class WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom.Everyone => "everyone",
                WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom.NonAdmins => "non_admins",
                WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom? ToEnum(string value)
        {
            return value switch
            {
                "everyone" => WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom.Everyone,
                "non_admins" => WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom.NonAdmins,
                "off" => WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom.Off,
                _ => null,
            };
        }
    }
}