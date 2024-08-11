//HintName: G.Models.WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy
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
    public static class WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestLabeledPullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}