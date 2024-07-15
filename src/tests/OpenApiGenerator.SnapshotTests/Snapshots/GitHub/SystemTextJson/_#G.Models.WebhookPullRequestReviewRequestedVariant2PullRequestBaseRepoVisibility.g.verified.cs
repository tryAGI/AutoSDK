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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Internal => "internal",
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
                "public" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}