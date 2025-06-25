//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}