//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}