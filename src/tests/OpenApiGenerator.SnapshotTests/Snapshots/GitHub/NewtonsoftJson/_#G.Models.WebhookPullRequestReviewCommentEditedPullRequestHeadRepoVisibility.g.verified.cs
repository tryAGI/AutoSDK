//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewCommentEditedPullRequestHeadRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}