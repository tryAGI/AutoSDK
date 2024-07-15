//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}