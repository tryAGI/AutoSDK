//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant2RequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}