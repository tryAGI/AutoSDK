//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneesType.Organization,
                _ => null,
            };
        }
    }
}