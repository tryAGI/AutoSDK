//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}