//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}