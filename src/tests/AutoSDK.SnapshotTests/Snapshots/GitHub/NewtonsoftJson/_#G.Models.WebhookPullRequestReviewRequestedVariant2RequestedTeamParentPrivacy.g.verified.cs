//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}