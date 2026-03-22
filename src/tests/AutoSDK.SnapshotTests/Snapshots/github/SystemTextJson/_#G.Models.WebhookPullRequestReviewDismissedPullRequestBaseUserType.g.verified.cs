//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestBaseUserType
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
    public static class WebhookPullRequestReviewDismissedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestReviewDismissedPullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}