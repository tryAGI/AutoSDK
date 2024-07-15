//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneeType.Organization,
                _ => null,
            };
        }
    }
}