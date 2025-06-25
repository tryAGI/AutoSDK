//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewEditedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}