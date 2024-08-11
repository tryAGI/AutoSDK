//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2ParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}