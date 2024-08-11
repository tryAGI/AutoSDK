//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType
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
    public static class WebhookPullRequestReviewThreadUnresolvedThreadCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedThreadCommentUserType.Organization,
                _ => null,
            };
        }
    }
}