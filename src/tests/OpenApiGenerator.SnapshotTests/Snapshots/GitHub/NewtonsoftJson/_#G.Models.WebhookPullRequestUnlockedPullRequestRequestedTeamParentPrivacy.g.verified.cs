//HintName: G.Models.WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestUnlockedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}