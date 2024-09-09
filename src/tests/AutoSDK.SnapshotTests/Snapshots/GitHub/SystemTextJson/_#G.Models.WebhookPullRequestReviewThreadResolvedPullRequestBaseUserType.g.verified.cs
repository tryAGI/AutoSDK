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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
                WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.Organization => "Organization",
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
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}