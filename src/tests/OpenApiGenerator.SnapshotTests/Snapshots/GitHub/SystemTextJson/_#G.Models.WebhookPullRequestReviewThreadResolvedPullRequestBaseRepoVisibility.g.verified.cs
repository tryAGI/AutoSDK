//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}