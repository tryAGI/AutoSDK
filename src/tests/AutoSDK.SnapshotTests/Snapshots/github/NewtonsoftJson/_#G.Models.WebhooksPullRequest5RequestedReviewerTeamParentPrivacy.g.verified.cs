//HintName: G.Models.WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5RequestedReviewerTeamParentPrivacy
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
    public static class WebhooksPullRequest5RequestedReviewerTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedReviewerTeamParentPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.Open => "open",
                WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedReviewerTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.Closed,
                "open" => WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.Open,
                "secret" => WebhooksPullRequest5RequestedReviewerTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}