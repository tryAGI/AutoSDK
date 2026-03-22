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
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
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
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}