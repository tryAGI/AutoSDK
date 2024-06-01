//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}