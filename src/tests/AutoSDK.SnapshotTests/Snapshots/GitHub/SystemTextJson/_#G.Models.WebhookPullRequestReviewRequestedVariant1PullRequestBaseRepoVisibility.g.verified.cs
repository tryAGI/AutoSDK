//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}