//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestUserType.Organization,
                _ => null,
            };
        }
    }
}