//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestSynchronizePullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}