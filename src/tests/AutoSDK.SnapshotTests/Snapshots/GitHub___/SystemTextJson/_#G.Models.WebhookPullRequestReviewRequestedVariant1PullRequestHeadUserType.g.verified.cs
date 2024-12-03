//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}