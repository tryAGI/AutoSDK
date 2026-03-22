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
    public static class WebhookPullRequestReviewEditedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Public => "public",
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
                "internal" => WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestReviewEditedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}