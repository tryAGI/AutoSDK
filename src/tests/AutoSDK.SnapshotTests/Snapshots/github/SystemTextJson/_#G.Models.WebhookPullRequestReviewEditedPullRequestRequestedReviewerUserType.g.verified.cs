//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}