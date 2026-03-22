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
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.User => "User",
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
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}