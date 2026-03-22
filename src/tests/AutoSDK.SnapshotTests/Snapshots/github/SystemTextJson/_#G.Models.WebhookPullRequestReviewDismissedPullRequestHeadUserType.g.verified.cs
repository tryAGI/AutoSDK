//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestHeadUserType
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
    public static class WebhookPullRequestReviewDismissedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestReviewDismissedPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}