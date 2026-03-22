//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestReviewEditedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestReviewEditedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}