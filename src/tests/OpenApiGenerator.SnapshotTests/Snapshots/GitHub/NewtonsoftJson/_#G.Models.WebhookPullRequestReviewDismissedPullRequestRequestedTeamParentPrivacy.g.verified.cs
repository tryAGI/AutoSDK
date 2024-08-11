//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}