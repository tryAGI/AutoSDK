//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}