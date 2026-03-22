//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType.Bot,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}