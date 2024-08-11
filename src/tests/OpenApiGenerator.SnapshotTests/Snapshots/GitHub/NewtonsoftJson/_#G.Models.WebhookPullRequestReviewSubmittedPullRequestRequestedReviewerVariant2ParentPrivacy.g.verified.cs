//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy
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
    public static class WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy.Open => "open",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant2ParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}