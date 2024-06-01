//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}