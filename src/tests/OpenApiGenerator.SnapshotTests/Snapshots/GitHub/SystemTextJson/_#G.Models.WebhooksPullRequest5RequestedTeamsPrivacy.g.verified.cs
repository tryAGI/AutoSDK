//HintName: G.Models.WebhooksPullRequest5RequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5RequestedTeamsPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPullRequest5RequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedTeamsPrivacy.Open => "open",
                WebhooksPullRequest5RequestedTeamsPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksPullRequest5RequestedTeamsPrivacy.Open,
                "closed" => WebhooksPullRequest5RequestedTeamsPrivacy.Closed,
                "secret" => WebhooksPullRequest5RequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}