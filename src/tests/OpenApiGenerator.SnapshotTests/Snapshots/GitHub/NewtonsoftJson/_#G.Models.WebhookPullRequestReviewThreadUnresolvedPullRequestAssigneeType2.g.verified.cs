//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}