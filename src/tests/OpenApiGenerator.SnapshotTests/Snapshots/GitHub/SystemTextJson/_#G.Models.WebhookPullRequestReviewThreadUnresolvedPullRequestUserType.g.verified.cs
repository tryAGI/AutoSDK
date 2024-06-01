//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestUserType
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestUserType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}