//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewDismissedPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}