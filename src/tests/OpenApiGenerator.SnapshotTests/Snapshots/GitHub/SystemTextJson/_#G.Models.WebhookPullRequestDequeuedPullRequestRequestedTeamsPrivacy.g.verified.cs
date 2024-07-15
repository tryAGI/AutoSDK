//HintName: G.Models.WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestDequeuedPullRequestRequestedTeamsPrivacy.Secret,
                _ => null,
            };
        }
    }
}