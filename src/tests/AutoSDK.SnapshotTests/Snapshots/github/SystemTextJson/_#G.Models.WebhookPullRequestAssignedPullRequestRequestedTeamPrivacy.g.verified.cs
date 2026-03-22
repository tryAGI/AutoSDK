//HintName: G.Models.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestAssignedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.Closed,
                "open" => WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.Open,
                "secret" => WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}