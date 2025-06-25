//HintName: G.Models.WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestAssignedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}