//HintName: G.Models.WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestAssignedPullRequestRequestedTeamsParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}