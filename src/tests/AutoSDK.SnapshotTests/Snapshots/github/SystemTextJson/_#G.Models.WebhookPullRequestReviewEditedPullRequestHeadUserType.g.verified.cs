//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestHeadUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookPullRequestReviewEditedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestReviewEditedPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestReviewEditedPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}