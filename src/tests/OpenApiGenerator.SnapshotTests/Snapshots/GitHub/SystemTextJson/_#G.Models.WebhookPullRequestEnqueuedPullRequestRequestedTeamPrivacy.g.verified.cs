//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestEnqueuedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}