//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}