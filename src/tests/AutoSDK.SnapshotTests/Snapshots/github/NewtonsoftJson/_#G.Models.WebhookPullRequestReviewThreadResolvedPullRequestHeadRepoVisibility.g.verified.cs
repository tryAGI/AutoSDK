//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}