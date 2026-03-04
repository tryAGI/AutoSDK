//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}