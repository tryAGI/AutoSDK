//HintName: G.Models.WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy
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
    public static class WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy.Open => "open",
                WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestUnlockedPullRequestRequestedReviewerTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}