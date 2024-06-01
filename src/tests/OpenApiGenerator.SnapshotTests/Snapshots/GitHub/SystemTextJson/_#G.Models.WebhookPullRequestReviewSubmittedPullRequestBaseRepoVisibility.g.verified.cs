//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}