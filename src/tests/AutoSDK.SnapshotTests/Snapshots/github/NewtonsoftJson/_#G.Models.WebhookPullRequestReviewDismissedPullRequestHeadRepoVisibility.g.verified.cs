//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestReviewDismissedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}