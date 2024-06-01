//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}