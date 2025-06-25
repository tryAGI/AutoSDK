//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}