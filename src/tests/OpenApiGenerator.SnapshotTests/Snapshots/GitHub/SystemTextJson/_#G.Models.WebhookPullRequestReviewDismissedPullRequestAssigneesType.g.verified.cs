//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestAssigneesType
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
    public static class WebhookPullRequestReviewDismissedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewDismissedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewDismissedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}