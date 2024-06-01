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
                WebhookPullRequestReviewDismissedPullRequestUserType.User => "User",
                WebhookPullRequestReviewDismissedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewDismissedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}