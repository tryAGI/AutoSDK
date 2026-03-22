//HintName: G.Models.WebhookPullRequestReviewDismissedReviewUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedReviewUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
    public static class WebhookPullRequestReviewDismissedReviewUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedReviewUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedReviewUserType.Bot => "Bot",
                WebhookPullRequestReviewDismissedReviewUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewDismissedReviewUserType.Organization => "Organization",
                WebhookPullRequestReviewDismissedReviewUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedReviewUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedReviewUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewDismissedReviewUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewDismissedReviewUserType.Organization,
                "User" => WebhookPullRequestReviewDismissedReviewUserType.User,
                _ => null,
            };
        }
    }
}