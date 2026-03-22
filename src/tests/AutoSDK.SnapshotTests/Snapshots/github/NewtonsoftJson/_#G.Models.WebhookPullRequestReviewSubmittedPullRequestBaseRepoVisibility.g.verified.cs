//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}