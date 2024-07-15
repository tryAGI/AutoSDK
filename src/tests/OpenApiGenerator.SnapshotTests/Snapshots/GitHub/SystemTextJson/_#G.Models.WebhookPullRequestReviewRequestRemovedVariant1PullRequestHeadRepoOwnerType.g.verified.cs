//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}