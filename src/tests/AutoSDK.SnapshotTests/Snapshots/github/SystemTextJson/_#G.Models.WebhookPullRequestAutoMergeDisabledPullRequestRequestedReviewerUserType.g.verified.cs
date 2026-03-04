//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}