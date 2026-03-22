//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}