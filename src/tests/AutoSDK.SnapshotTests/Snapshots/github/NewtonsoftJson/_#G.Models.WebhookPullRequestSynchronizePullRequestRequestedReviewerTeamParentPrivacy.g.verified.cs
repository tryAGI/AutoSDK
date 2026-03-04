//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy
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
    public static class WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}