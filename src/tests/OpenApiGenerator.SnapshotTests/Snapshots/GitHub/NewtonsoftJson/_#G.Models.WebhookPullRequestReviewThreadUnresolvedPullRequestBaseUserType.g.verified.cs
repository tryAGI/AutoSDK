//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}