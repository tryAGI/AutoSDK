//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewEditedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}