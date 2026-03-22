//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Organization,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.User,
                _ => null,
            };
        }
    }
}