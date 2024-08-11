//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}