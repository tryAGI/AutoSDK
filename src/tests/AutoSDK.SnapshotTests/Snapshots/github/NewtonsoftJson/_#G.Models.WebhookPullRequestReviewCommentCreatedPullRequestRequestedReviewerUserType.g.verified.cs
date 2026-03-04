//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}