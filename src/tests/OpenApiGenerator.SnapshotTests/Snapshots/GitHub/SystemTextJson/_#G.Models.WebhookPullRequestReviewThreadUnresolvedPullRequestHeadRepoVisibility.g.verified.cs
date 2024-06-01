//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}