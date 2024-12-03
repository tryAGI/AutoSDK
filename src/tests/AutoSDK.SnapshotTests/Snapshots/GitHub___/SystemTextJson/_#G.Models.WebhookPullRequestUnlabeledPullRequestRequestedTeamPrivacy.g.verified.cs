//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Closed => "closed",
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
                "open" => WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestUnlabeledPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}