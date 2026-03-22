//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Closed,
                "open" => WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Open,
                "secret" => WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}