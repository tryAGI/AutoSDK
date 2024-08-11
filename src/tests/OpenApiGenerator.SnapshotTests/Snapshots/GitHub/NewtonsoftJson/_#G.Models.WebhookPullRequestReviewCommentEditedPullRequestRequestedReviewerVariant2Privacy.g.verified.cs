//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}