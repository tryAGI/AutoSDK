//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}