//HintName: G.Models.WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy
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
    public static class WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy.Open => "open",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestDequeuedPullRequestRequestedReviewerTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}