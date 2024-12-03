//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewCommentEditedPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}