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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestReviewThreadResolvedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}