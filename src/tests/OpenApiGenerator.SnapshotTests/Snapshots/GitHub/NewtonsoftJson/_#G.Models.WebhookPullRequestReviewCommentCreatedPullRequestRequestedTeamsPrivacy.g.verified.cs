//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}