//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}