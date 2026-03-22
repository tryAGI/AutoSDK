//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestUserType
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
    public static class WebhookPullRequestReviewDismissedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewDismissedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestUserType.Organization,
                "User" => WebhookPullRequestReviewDismissedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}