//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestUserType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewRequestedVariant1PullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant1PullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestUserType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestUserType.User,
                _ => null,
            };
        }
    }
}