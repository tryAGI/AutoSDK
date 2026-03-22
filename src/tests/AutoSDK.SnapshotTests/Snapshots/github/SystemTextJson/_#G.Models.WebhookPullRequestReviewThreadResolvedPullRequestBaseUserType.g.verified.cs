//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}