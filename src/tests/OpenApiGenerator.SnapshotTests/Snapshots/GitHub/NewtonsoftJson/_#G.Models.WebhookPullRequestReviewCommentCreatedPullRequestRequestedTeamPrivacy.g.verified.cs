//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}