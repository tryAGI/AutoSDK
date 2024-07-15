//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentDeletedPullRequestUserType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}