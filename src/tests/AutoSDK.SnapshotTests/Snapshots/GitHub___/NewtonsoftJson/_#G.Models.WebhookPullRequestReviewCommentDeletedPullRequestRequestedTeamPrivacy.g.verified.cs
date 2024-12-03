//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}