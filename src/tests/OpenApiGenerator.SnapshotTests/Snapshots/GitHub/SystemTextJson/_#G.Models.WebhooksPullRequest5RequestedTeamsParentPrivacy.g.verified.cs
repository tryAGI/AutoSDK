//HintName: G.Models.WebhooksPullRequest5RequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5RequestedTeamsParentPrivacy
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
    public static class WebhooksPullRequest5RequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedTeamsParentPrivacy.Open => "open",
                WebhooksPullRequest5RequestedTeamsParentPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedTeamsParentPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksPullRequest5RequestedTeamsParentPrivacy.Open,
                "closed" => WebhooksPullRequest5RequestedTeamsParentPrivacy.Closed,
                "secret" => WebhooksPullRequest5RequestedTeamsParentPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}