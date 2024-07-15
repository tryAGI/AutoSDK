//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}