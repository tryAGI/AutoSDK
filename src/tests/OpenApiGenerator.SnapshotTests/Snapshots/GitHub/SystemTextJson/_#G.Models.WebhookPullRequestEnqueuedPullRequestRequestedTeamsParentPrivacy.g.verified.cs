//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestEnqueuedPullRequestRequestedTeamsParentPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}