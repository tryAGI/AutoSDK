//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}