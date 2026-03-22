//HintName: G.Models.WebhooksPullRequest5RequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5RequestedTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPullRequest5RequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedTeamPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedTeamPrivacy.Open => "open",
                WebhooksPullRequest5RequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhooksPullRequest5RequestedTeamPrivacy.Closed,
                "open" => WebhooksPullRequest5RequestedTeamPrivacy.Open,
                "secret" => WebhooksPullRequest5RequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}