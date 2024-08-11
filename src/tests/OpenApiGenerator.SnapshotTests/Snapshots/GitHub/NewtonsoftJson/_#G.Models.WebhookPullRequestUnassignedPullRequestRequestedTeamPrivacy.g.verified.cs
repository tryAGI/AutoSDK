//HintName: G.Models.WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestUnassignedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}