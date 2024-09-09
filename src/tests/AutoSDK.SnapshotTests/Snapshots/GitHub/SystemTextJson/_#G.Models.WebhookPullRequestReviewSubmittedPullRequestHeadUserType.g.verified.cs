//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestHeadUserType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestHeadUserType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}