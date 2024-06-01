//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamsParentPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}