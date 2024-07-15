//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}