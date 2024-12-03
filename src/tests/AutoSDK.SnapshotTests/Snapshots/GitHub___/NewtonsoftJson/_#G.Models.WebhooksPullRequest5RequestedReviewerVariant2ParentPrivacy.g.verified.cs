//HintName: G.Models.WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy
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
    public static class WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.Open => "open",
                WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.Open,
                "closed" => WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.Closed,
                "secret" => WebhooksPullRequest5RequestedReviewerVariant2ParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}