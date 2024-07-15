//HintName: G.Models.WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Secret,
                _ => null,
            };
        }
    }
}