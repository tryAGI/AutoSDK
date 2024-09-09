//HintName: G.Models.WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestLockedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestLockedPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}