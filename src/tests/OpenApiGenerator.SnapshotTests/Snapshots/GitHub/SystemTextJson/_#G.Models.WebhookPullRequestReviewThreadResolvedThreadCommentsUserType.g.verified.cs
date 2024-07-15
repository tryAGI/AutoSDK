//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentsUserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentsUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentsUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentsUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Mannequin,
                _ => null,
            };
        }
    }
}