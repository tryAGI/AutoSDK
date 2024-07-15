//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}