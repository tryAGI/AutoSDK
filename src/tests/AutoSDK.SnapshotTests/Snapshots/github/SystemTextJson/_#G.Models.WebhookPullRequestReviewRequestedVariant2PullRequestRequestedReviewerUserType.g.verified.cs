//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType.Bot,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}