//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}