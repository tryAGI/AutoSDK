//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}