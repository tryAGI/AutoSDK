//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentsUserType
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
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentsUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentsUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentsUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewThreadResolvedThreadCommentsUserType.Mannequin,
                _ => null,
            };
        }
    }
}