//HintName: G.Models.WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestUnlockedPullRequestRequestedTeamsParentPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}