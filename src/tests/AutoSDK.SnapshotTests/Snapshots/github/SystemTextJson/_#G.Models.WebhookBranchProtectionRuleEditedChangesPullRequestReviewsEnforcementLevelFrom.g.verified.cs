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
    public static class WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom value)
        {
            return value switch
            {
                WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Everyone => "everyone",
                WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.NonAdmins => "non_admins",
                WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Off => "off",
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
                "everyone" => WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Everyone,
                "non_admins" => WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.NonAdmins,
                "off" => WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom.Off,
                _ => null,
            };
        }
    }
}