//HintName: G.Models.WebhooksPullRequest5RequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5RequestedReviewerTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPullRequest5RequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedReviewerTeamPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedReviewerTeamPrivacy.Open => "open",
                WebhooksPullRequest5RequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhooksPullRequest5RequestedReviewerTeamPrivacy.Closed,
                "open" => WebhooksPullRequest5RequestedReviewerTeamPrivacy.Open,
                "secret" => WebhooksPullRequest5RequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}