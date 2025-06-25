//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}