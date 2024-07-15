//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}