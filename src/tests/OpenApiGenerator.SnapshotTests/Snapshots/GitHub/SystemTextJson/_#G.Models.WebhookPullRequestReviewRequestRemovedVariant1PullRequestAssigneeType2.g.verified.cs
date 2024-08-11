//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}