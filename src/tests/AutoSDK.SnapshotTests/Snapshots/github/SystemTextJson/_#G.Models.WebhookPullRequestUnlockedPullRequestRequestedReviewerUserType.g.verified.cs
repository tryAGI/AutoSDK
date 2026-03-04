//HintName: G.Models.WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnlockedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestRequestedReviewerUserType.Organization,
                _ => null,
            };
        }
    }
}