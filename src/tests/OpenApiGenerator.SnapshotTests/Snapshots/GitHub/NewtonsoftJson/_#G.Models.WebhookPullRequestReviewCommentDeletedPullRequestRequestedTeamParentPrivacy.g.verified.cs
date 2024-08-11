//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}