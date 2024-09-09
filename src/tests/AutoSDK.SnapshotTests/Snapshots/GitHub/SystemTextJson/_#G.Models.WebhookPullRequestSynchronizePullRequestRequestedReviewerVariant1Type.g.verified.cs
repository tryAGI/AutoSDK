//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}