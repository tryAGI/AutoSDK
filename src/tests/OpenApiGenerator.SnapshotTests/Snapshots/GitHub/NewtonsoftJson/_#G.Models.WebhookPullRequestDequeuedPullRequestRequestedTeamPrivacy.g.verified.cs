//HintName: G.Models.WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestDequeuedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}