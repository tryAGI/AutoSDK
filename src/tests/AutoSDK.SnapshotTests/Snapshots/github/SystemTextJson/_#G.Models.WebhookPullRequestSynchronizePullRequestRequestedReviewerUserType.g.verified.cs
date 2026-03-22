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
                WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.User => "User",
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
                "Mannequin" => WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestSynchronizePullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}