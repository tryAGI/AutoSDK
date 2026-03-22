//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}