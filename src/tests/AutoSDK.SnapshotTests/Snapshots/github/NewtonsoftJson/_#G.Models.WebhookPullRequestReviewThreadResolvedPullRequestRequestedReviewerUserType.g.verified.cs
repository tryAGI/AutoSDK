//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}