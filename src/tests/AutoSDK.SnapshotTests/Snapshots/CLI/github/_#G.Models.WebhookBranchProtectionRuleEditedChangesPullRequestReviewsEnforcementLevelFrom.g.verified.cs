//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom
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
    public static class WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Off => "off",
                WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.NonAdmins => "non_admins",
                WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom? ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Off,
                "non_admins" => WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.NonAdmins,
                "everyone" => WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Everyone,
                _ => null,
            };
        }
    }
}