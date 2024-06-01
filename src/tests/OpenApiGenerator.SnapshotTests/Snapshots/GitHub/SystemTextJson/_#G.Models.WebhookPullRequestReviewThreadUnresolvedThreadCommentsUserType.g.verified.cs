//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType
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
    public static class WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedThreadCommentsUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}