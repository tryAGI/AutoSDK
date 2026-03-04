//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerUserType.Organization,
                _ => null,
            };
        }
    }
}