//HintName: G.Models.WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestDequeuedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestRequestedReviewerUserType.Organization,
                _ => null,
            };
        }
    }
}