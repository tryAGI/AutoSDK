//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Bot,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Organization,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.User,
                _ => null,
            };
        }
    }
}