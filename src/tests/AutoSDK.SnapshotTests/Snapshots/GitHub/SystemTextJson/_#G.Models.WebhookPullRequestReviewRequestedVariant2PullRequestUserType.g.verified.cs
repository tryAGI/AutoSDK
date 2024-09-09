//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestUserType
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}