//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}