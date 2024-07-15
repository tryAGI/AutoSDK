//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestRemovedVariant2RequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}