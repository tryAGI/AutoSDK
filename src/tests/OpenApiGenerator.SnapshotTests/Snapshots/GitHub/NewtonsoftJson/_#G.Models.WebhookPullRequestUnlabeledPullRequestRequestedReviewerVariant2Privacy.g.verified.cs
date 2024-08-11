//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}