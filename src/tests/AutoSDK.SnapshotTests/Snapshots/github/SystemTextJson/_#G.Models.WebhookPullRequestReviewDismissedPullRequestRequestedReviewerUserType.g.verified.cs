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
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
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
                "User" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}