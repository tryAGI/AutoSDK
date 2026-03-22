//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}