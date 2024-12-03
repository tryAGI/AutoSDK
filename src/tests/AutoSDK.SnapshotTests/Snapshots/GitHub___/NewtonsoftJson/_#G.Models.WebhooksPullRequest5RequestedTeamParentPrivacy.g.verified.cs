//HintName: G.Models.WebhooksPullRequest5RequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5RequestedTeamParentPrivacy
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
    public static class WebhooksPullRequest5RequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedTeamParentPrivacy.Open => "open",
                WebhooksPullRequest5RequestedTeamParentPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksPullRequest5RequestedTeamParentPrivacy.Open,
                "closed" => WebhooksPullRequest5RequestedTeamParentPrivacy.Closed,
                "secret" => WebhooksPullRequest5RequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}