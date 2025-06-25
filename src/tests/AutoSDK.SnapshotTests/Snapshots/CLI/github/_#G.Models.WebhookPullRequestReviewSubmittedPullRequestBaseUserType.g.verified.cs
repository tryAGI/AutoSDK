//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestBaseUserType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}