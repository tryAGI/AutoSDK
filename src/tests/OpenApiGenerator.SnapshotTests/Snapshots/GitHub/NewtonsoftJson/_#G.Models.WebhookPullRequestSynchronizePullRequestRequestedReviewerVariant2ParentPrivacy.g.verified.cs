//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy
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
    public static class WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2ParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}