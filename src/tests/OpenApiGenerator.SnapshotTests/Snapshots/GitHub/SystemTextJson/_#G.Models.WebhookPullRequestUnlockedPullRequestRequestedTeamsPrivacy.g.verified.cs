//HintName: G.Models.WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestUnlockedPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}