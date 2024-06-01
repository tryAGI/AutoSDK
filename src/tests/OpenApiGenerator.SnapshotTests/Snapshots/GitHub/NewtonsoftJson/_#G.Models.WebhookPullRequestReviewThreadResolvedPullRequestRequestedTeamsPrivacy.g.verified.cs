//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}